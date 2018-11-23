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
        //获取部门下全部员工
        public static DataTable AllEmpolyeesOf(TreeNode treeNode)
        {
            Department department = new Department();
            List<int> DepartmentId = readNode(treeNode);
            DataTable datatable = new DataTable();
            for (int i = 0; i < DepartmentId.Count; i++)
            {
                SelectSqlMaker maker = new SelectSqlMaker("employee");
                maker.AddAndCondition(new IntEqual("em_departmentid", DepartmentId[i]));
                DataTable datatable1 = department.Select(maker.MakeSelectSql());
                if (i == 0)
                {
                    datatable = datatable1.Copy();
                    continue;
                }     
                foreach (DataRow dr in datatable1.Rows)
                {
                    datatable.ImportRow(dr);
                }
                datatable1 = null;
            }
            return datatable;
        }

        //读取节点的叶子节点ID
        private static List<int> readNode(TreeNode treeNode)
        {
            List<int> DepartmentId = new List<int>();
            if (treeNode.Nodes.Count == 0)
            {
                DepartmentId.Add((int)treeNode.Tag);
                return DepartmentId;
            }
            foreach (TreeNode children in treeNode.Nodes)
            {
                DepartmentId.AddRange(readNode(children));
            }
            return DepartmentId;
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
            if(!HasDepartment(department)) throw new Exception("不存在该小组");
            if(HasSonDepartment(department)) throw new Exception("该部门之下还有子部门");
            if(HasEmployee(department)) throw new Exception("该部门之下存在员工");
        }

        //该部门是否存在
        private static bool HasDepartment(Department department)
        {
            SelectSqlMaker maker = new SelectSqlMaker("department");
            maker.AddAndCondition(new IntEqual("de_id", department.de_id.Value));
            DataTable dataTable = department.Select(maker.MakeSelectSql());
            return dataTable.Rows.Count > 0;
        }

        //是否存在子部门
        private static bool HasSonDepartment(Department department)
        {
            SelectSqlMaker maker = new SelectSqlMaker("department");
            maker.AddAndCondition(new IntEqual("de_belongid", department.de_id.Value));
            DataTable departmentDataTable = department.Select(maker.MakeSelectSql());
            return departmentDataTable.Rows.Count != 0;
        }

        //是否存在员工
        private static bool HasEmployee(Department department)
        {
            SelectSqlMaker maker = new SelectSqlMaker("department");
            maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_departmentid", department.de_id.Value));
            DataTable employeeDataTable = department.Select(maker.MakeSelectSql());
            return employeeDataTable.Rows.Count != 0;
        }

        //添加部门
        public static void AddDepartment(string name, int belongId)
        {
            Department department = new Department();
            department.de_name = name;
            department.de_belongId = belongId;
            if (!NodeDuplicateChecking(department)) throw new Exception("该部门名字已经存在");
            department.Insert();
        }

        //修改部门
        public static void UpdateDepartment(int id, string name, int belongId)
        {
            Department department = new Department();
            department.de_id = id;
            department.de_name = name;
            department.de_belongId = belongId;
            if(!NodeDuplicateChecking(department)) throw new Exception("该部门名字已经存在");
            department.Update();
        }

        //部门名字查重
        private static bool NodeDuplicateChecking(Department department)
        {
            SelectSqlMaker maker = new SelectSqlMaker("department");
            maker.AddAndCondition(new StringEqual("de_name", department.de_name));
            maker.AddAndCondition(new IntEqual("de_belongid", department.de_belongId.Value));
            DataTable departmentDataTable = department.Select(maker.MakeSelectSql());
            return departmentDataTable.Rows.Count == 0;
        }

        //加载部门树状图
        public static void LoadTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();
            Department department = new Department();
            SelectSqlMaker maker = new SelectSqlMaker("department");
            DataTable dataTable = department.Select(maker.MakeSelectSql());
            if (dataTable.Rows.Count == 0) return;
            TreeNode rootNode = new TreeNode("所有部门");
            rootNode.Tag = 0;
            LoadSubNodes(rootNode);
            treeView.Nodes.Add(rootNode);
        }

        private static void LoadSubNodes(TreeNode parentNode)
        {
            int parentId = (int)parentNode.Tag;
            SelectSqlMaker make = new SelectSqlMaker("department");
            make.AddAndCondition(new IntEqual("de_belongid", parentId));
            DataTable dt = ActiveRecord.Select(make.MakeSelectSql(), DbLinkManager.databaseType,
                DbLinkManager.connectString);

            if (dt.Rows.Count == 0) return;

            foreach (DataRow dataRow in dt.Rows)
            {
                TreeNode childNode = new TreeNode((string)dataRow["de_name"]) { Tag = (int)dataRow["de_id"] };
                parentNode.Nodes.Add(childNode);
                LoadSubNodes(childNode);
            }
        }

        //全部部门
        public static DataTable AllDepartments()
        {
            Department department = new Department();
            SelectSqlMaker maker = new SelectSqlMaker("t_department");
            DataTable dataTable = department.Select(maker.MakeSelectSql());
            return dataTable;
        }

        //查询节点名字，以及父节点名
        public static List<string> ReadDepartmentNodeName(int departmentid)
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
