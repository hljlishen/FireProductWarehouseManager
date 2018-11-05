using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    class DepartmentGateway
    {
        public static void AddEmployee(int departmentId, int employeeId)
        {

        }

        public static List<Employee> AllEmpolyeesOf(int departmentId)
        {
            List<Employee> list = new List<Employee>();
            return list;
        }

        public static bool IsIdExist(int depatmentId)
        {
            return false;
        }

        public static bool DeleteEmployee(int departmentId)
        {
            Department department = new Department();
            department.de_id = departmentId;
            department.Delete();
            return true;
        }

        public static void AddDepartment(string name, int belongId) //?????函数名称，验证
        {
            Department department = new Department();
            department.de_name = name;
            department.de_belongId = belongId;
            department.Insert();
        }

        public static void LoadTreeView(TreeView treeView, int parentId = 0)    //?????parentId??
        {
            Department department = new Department();
            SelectSqlMaker maker = new SelectSqlMaker("t_department");
            maker.AddAndCondition(new IntEqual("de_belongid", parentId));
            DataTable dt = department.Select(maker.MakeSelectSql());

            if (dt.Rows.Count == 0) return;

                int pId = -1;
                foreach (DataRow row in dt.Rows)
                {
                    TreeNode node = new TreeNode();
                    node.Text = row["de_name"].ToString();
                    node.Tag = (int)row["de_id"];
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

        public static List<Department> AllDepartments()
        {
            List<Department> list = new List<Department>();
            return list;
        }

    }
}
