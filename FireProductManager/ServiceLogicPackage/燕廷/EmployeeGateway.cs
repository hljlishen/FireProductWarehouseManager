using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using DbLink;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FireProductManager.ServiceLogicPackage
{
    class EmployeeGateway
    {
        //删除员工
        public static bool DeleteEmployee(int employeeId)
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            employee.Delete();
            return true;
        }

        //修改员工
        public static bool UpdateEmployee(Employee employee)
        {
            employee.Update();
            return true;
        }

        //添加员工
        public static void AddEmployee(Employee employee)
        {
            employee.Insert();
        }

        //表单验证
        private static Dictionary<string, string> FormValidation(Employee employee)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("", IdValidation(employee));
            myDictionary.Add("", NameValidation(employee));
            return myDictionary;
        }

        //em_id验证
        private static string IdValidation(Employee employee)
        {
            if (employee.em_employeenumber.Equals("")) {
                return "*员工编号不能为空";
            }
            SelectSqlMaker maker = new SelectSqlMaker("t_department");
            maker.AddAndCondition(new IntEqual("em_employeenumber", employee.em_employeenumber));
            DataTable dataTable = employee.Select(maker.MakeSelectSql());
            if (dataTable.Rows.Count != 0)
            {

                return "*员工编号已存在";
            }
            return "";
        }

        //em_name验证
        private static string NameValidation(Employee employee)
        {
            if (employee.em_employeenumber.Equals(""))
            {
                return "*员工姓名不能为空";
            }
            return "";
        }

        public static void SwitchDepartment(int employeeId,int departmentId)
        {
            
        }

        public static List<Employee> Query(string sql)
        {
            List<Employee> list = new List<Employee>();
            return list;
        }

       

    }
}
