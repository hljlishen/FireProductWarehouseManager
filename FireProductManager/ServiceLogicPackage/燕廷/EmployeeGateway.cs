using FireProductManager.EntityPackage;
using System;
using DbLink;
using System.Data;

namespace FireProductManager.ServiceLogicPackage
{
    public class EmployeeGateway
    {
        //删除员工
        public static void DeleteEmployee(int employeeId)
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            if (!HasEmployee(employee)) throw new Exception("不存在该员工");
            employee.Delete();
        }

        //员工是否存在
        private static bool HasEmployee(Employee employee)
        {
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_id", employee.em_id.Value));
            DataTable dataTable = employee.Select(maker.MakeSelectSql());
            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        //修改员工
        public static void UpdateEmployee( int employeeId, string employeeNumber, string name, string sex,int departmentId)
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            employee.em_employeenumber = employeeNumber;
            employee.em_name = name;
            employee.em_sex = sex;
            employee.em_departmentid = departmentId;
            employee.Update();
        }

        //添加员工 
        public static void NewEmployee(string employeeNumber, string name, string sex, int departmentId)
        {
            Employee employee = new Employee();;
            employee.em_employeenumber = employeeNumber;
            employee.em_name = name;
            employee.em_sex = sex;
            employee.em_departmentid = departmentId;
            employee.Insert();
        }

        //添加-验证EmployeeNumber
        public static bool NewValidationEmployeeNumber(string employeeNumber)
        {
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new StringEqual("em_employeenumber", employeeNumber));
            DataTable dataTable = ActiveRecord.Select(maker.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dataTable.Rows.Count != 0)
            {
                return false;
            }
            return true;
        }

        //更新-验证EmployeeNumber
        public static bool UpdateValidationEmployeeNumber(int id,string employeeNumber)
        {
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_id", id));
            DataTable dataTable = ActiveRecord.Select(maker.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            Employee em = new Employee();
            em.LoadDataRow(dataTable.Rows[0]);
            if (em.em_employeenumber.Equals(employeeNumber)) return true;

            SelectSqlMaker maker1 = new SelectSqlMaker("employee");
            maker1.AddAndCondition(new StringEqual("em_employeenumber", employeeNumber));
            DataTable dataTable1 = ActiveRecord.Select(maker1.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dataTable1.Rows.Count != 0)
            {
                return false;
            }
            return true;
        }

        //em_name验证
        private static bool NameValidation(string name)
        {
            return name.Equals("");
        }

        //em_departmentid验证
        private static bool DepartmentIdValidation(int deoartmentid)
        {
            return deoartmentid == -1;
        }

        //员工部门交换 
        public static void SwitchDepartment(int employeeId, int departmentId)
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            employee.em_departmentid = departmentId;
            employee.Update();
        }

        //获取员工信息
        public static Employee GetEmployeeInformation(int employeeId)
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_id", employee.em_id.Value));
            DataTable dataTable = employee.Select(maker.MakeSelectSql());
            foreach (DataRow dr in dataTable.Rows)
            {
                employee.em_employeenumber = (string)dr["em_employeenumber"];
                employee.em_name = (string)dr["em_name"];
                employee.em_sex = (string)dr["em_sex"];
                employee.em_departmentid = (int)dr["em_departmentid"];
            }
            return employee;
        }

        //获取全部员工
        public static DataTable GetAllEmployees()
        {
            Employee employee = new Employee();
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            return Query(maker.MakeSelectSql());
        }

        //员工搜索
        public static DataTable GetQueryEmployees(string employeenumber,string name,string sex)
        {
            if (sex.Equals("男/女")) sex = "";
            if (employeenumber.Equals("") && name.Equals("") && sex.Equals(""))
            {
                DataTable dataTable = GetAllEmployees();
                return dataTable;
            }
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new StringLike("em_employeenumber", employeenumber));
            maker.AddAndCondition(new StringLike("em_name", name));
            maker.AddAndCondition(new StringLike("em_sex", sex));
            return Query(maker.MakeSelectSql());
        }

        //员工查询 
        private static DataTable Query(string sql)
        {
            DataTable dataTable = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return dataTable;
        }

    }
}
