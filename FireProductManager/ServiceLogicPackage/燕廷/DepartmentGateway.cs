using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    class DepartmentGateway
    {
        public static void AddEmployee(int DepartmentId, int EmployeeId)
        {

        }

        public static List<Employee> AllEmpolyeesOf(Department department)
        {
            List<Employee> list = new List<Employee>();
            return list;
        }

        public static bool IsIdExist(int depatmentId)
        {
            return false;
        }

        public static bool DeleteEmployee(int DepartmentId)
        {
            return true;
        }

        public static void AddDepartmen(string name, int belongId)
        {

        }

        public static void LoadTreeView(TreeView treeView)
        {

        }

        public static List<Department> AllDepartments()
        {
            List<Department> list = new List<Department>();
            return list;
        }

    }
}
