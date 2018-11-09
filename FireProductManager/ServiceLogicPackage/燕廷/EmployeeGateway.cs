using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using DbLink;
using System.Data;

namespace FireProductManager.ServiceLogicPackage
{
    public class EmployeeGateway
    {
        private enum Operation
        {
            Update,
            New,
        }

        //删除员工
        public static bool DeleteEmployee(int employeeId)
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            HasEmployee(employee);
            employee.Delete();
            return true;
        }

        //员工是否存在
        private static void HasEmployee(Employee employee)
        {
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_id", employee.em_id.Value));
            DataTable dataTable = employee.Select(maker.MakeSelectSql());
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("不存在该员工");
            }
            return;
        }

        //修改员工
        public static void UpdateEmployee( int employeeId, string employeeNumber, string name, string sex,int departmentId)
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            employee.em_employeenumber = employeeNumber;
            employee.em_name = name;
            employee.em_sex = sex;
            employee.em_departmentId = departmentId;
            FormValidation(employee, Operation.Update);
            employee.Update();
        }

        //添加员工
        public static void NewEmployee(string employeeNumber, string name, string sex, int departmentId)
        {
            Employee employee = new Employee();;
            employee.em_employeenumber = employeeNumber;
            employee.em_name = name;
            employee.em_sex = sex;
            employee.em_departmentId = departmentId;
            FormValidation(employee, Operation.New);
            employee.Insert();
        }

        //表单验证
        private static void FormValidation(Employee employee, Operation operation)
        {
            IdValidation(employee, operation);
            NameValidation(employee);
        }

        //em_employeenumber验证
        private static void IdValidation(Employee employee, Operation operation)
        {
            if (employee.em_employeenumber.Equals("")) {
                throw new Exception("员工编号不能为空");
            }
            switch (operation)
            {
                case Operation.New:
                    NewEmployeeNumber(employee);
                    break;
                case Operation.Update:
                    UpdateEmployeeNumber(employee);
                    break;
            }
        }

        //添加EmployeeNumber
        private static void NewEmployeeNumber(Employee employee)
        {
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_employeenumber", employee.em_employeenumber));
            DataTable dataTable = employee.Select(maker.MakeSelectSql());
            if (dataTable.Rows.Count != 0)
            {

                throw new Exception("该员工编号已存在");
            }
        }

        //更新EmployeeNumber
        private static void UpdateEmployeeNumber(Employee employee)
        {
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_id", employee.em_id.Value));
            DataTable dataTable = employee.Select(maker.MakeSelectSql());
            Employee em = new Employee();
            foreach (DataRow dr in dataTable.Rows)
            {
                em.LoadDataRow(dr);
            }

            if (em.em_employeenumber == employee.em_employeenumber) return;

            maker.AddAndCondition(new IntEqual("em_employeenumber", employee.em_employeenumber));
            DataTable dataTable1 = employee.Select(maker.MakeSelectSql());
            if (dataTable1.Rows.Count != 0)
            {
                throw new Exception("该员工编号已存在");
            }
        }

        //em_name验证
        private static void NameValidation(Employee employee)
        {
            if (employee.em_employeenumber.Equals(""))
            {
                throw new Exception("员工姓名不能为空");
            }
        }

        //员工部门交换 ??
        public static void SwitchDepartment(int employeeId, int departmentId)
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            employee.em_departmentId = departmentId;
            employee.Update();
        }

        //员工查询
        public static List<Employee> Query(string sql)
        {
            DataTable dataTable = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            List<Employee> list = new List<Employee>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee();
                employee.LoadDataRow(dr);
                list.Add(employee);
            }
            return list;
        }
    }
}
