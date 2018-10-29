using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage
{
    class EmployeeGateway
    {
        public static bool DeleteEmployee(int employeeId)
        {
            return true;
        }

        public static void NewEmployee(string name,string number,int departmentId)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.EmployeeNumber = number;
            employee.DepartmentId = departmentId;
            employee.Insert();

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
