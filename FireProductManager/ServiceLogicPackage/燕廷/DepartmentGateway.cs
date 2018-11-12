using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    class DepartmentGateway
    {
        private static List<int> DepartmentId = new List<int>();

        //获取部门下全部员工
        public static List<Employee> AllEmpolyeesOf(TreeNode treeNode)
        {
            List<Employee> list = new List<Employee>();
            Department department = new Department();
            readNode(treeNode);
            DataTable datatable = new DataTable();
            string sql1 = "select * from t_employee where em_departmentid =";
            string sql2 = " or em_departmentid =";
            string sql = "";
            for (int i = 0; i < DepartmentId.Count; i++)
            {
                if (i == 0)
                {
                    sql = sql1 + DepartmentId[i];
                    continue;
                }
                sql += sql2 + DepartmentId[i];
            }
            datatable = department.Select(sql);
            return list;
        }

        //读取节点的叶子节点ID
        public static void readNode(TreeNode treeNode)
        {
            if (treeNode.Nodes.Count == 0)
            {
                DepartmentId.Add((int)treeNode.Tag);
                return;
            }
            foreach (TreeNode children in treeNode.Nodes)
            {
                if (children.Nodes.Count == 0)
                {
                    DepartmentId.Add((int)children.Tag);
                }
                readNode(children);
            }
        }

        //部门删除
        public static bool DeleteDepartment(int departmentId)
        {
            Department department = new Department();
            department.de_id = departmentId;
            DeleteDepartmentVerification(department);
            department.Delete();
            return true;
        }

        //部门删除验证
        private static void DeleteDepartmentVerification(Department department)
        {
            HasDepartment(department);
            HasSonDepartment(department);
            HasEmployee(department);
        }

        //该部门是否存在
        private static void HasDepartment(Department department)
        {
            SelectSqlMaker maker = new SelectSqlMaker("department");
            maker.AddAndCondition(new IntEqual("de_id", department.de_id.Value));
            DataTable dataTable = department.Select(maker.MakeSelectSql());
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("不存在该小组");
            }
            return;
        }

        //是否存在子部门
        private static void HasSonDepartment(Department department)
        {
            SelectSqlMaker maker = new SelectSqlMaker("department");
            maker.AddAndCondition(new IntEqual("de_belongid", department.de_id.Value));
            DataTable departmentDataTable = department.Select(maker.MakeSelectSql());
            if (departmentDataTable.Rows.Count != 0)
            {
                throw new Exception("该部门之下还有子部门");
            }
            return;
        }

        //是否存在员工
        private static void HasEmployee(Department department)
        {
            SelectSqlMaker maker = new SelectSqlMaker("department");
            maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_departmentid", department.de_id.Value));
            DataTable employeeDataTable = department.Select(maker.MakeSelectSql());
            if (employeeDataTable.Rows.Count != 0)
            {
                throw new Exception("该部门之下存在员工");
            }
            return;
        }

        //添加部门
        public static void AddDepartment(string name, int belongId)
        {
            Department department = new Department();
            department.de_name = name;
            department.de_belongId = belongId;
            NodeDuplicateChecking(department);
            department.Insert();
        }

        //修改部门
        public static void UpdateDepartment(int id, string name, int belongId)
        {
            Department department = new Department();
            department.de_id = id;
            department.de_name = name;
            department.de_belongId = belongId;
            NodeDuplicateChecking(department);
            department.Update();
        }

        //部门名字查重
        private static void NodeDuplicateChecking(Department department)
        {
            SelectSqlMaker maker = new SelectSqlMaker("department");
            maker.AddAndCondition(new StringEqual("de_name", department.de_name));
            maker.AddAndCondition(new IntEqual("de_belongid", department.de_belongId.Value));
            DataTable departmentDataTable = department.Select(maker.MakeSelectSql());
            if (departmentDataTable.Rows.Count == 0)
            {
                return;
            }
            throw new Exception("该部门名字已经存在");
        }

        //加载部门树状图
        public static void LoadTreeView(TreeView treeView, int parentId = 0)
        {
            Department department = new Department();
            SelectSqlMaker maker = new SelectSqlMaker("department");
            maker.AddAndCondition(new IntEqual("de_belongid", parentId));
            DataTable dataTable = department.Select(maker.MakeSelectSql());
            if (dataTable.Rows.Count == 0) return;
            InitializeNode(treeView, dataTable);
        }

        //Node初始化
        private static void InitializeNode(TreeView treeView,DataTable dataTable)
        {
            int pId = -1;
            foreach (DataRow row in dataTable.Rows)
            {
                TreeNode node = new TreeNode();
                Department department = new Department();
                department.LoadDataRow(row);
                node.Text = row["de_name"].ToString();
                node.Tag = row["de_id"];
                pId = (int)row["de_belongid"];
                if (pId == 0)
                {
                    treeView.Nodes.Add(node);//添加根节点
                }
                else
                {
                    RefreshChildNode(treeView, node, pId);//添加根节点之外的其他节点
                }
                LoadTreeView(treeView, (int)node.Tag);//查找以node为父节点的子节点
            }
        }

        //处理根节点的子节点
        private static void RefreshChildNode(TreeView treeView, TreeNode treeNode, int parentId)
        {
            foreach (TreeNode node in treeView.Nodes)
            {
                if ((int)node.Tag == parentId)
                {
                    node.Nodes.Add(treeNode);
                    return;
                }
                else if (node.Nodes.Count > 0)
                {
                    FindChildNode(node, treeNode, parentId);
                }
            }
        }

        //处理根节点的子节点的子节点
        private static void FindChildNode(TreeNode tNode, TreeNode treeNode, int parentId)
        {
            foreach (TreeNode node in tNode.Nodes)
            {
                if ((int)node.Tag == parentId)
                {
                    node.Nodes.Add(treeNode);
                    return;
                }
                else if (node.Nodes.Count > 0)
                {
                    FindChildNode(node, treeNode, parentId);
                }
            }
        }

        //全部部门
        public static List<Department> AllDepartments()
        {
            Department department = new Department();
            SelectSqlMaker maker = new SelectSqlMaker("t_department");
            DataTable dataTable = department.Select(maker.MakeSelectSql());
            List<Department> list = new List<Department>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Department p = new Department();
                p.LoadDataRow(dr);
                list.Add(p);
            }
            return list;
        }

        //查询节点名字，以及父节点名
        public static List<string> DepartmentName(int departmentid)
        {
            Department department = new Department();
            department.de_id = departmentid;
            List<string> mList = new List<string>();
            while (true)
            {
                SelectSqlMaker maker = new SelectSqlMaker("department");
                maker.AddAndCondition(new IntEqual("de_id", departmentid));
                DataTable departmentDataTable = department.Select(maker.MakeSelectSql());
                DataRow myDr = departmentDataTable.Rows[0];
                mList.Add(myDr["de_name"].ToString());
                if ((int)myDr["de_belongid"] == 0) break;
                departmentid = (int)myDr["de_belongid"];
            }
            return mList;
        }
    }
}
