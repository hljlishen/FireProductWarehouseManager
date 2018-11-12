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
        public static void DeleteEmployee(int employeeId)   //？？？？？？返回值不必要
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            if(!HasEmployee(employee))
                throw new Exception("12323231");
            employee.Delete();
            return ;
        }

        //员工是否存在
        private static bool HasEmployee(Employee employee)  //应返回bool？？？？？？？？
        {
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_id", employee.em_id.Value));
            DataTable dataTable = employee.Select(maker.MakeSelectSql());
            return dataTable.Rows.Count != 0;
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
            FormValidation(employee, Operation.Update);
            employee.Update();
        }

        //添加员工 ??编码不能为汉字
        public static void NewEmployee(string employeeNumber, string name, string sex, int departmentId)
        {
            Employee employee = new Employee();;
            employee.em_employeenumber = employeeNumber;
            employee.em_name = name;
            employee.em_sex = sex;
            employee.em_departmentid = departmentId;
            FormValidation(employee, Operation.New);
            employee.Insert();
        }

        //表单验证
        private static void FormValidation(Employee employee, Operation operation)
        {
            IdValidation(employee, operation);
            NameValidation(employee);
            DepartmentIdValidation(employee);
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
        private static void UpdateEmployeeNumber(Employee employee)     //？？？？？？
        {
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new IntEqual("em_id", employee.em_id.Value));
            DataTable dataTable = employee.Select(maker.MakeSelectSql());
            Employee em = new Employee();

            em.LoadDataRow(dataTable.Rows[0]);

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

        //em_departmentid验证
        private static void DepartmentIdValidation(Employee employee)
        {
            if (employee.em_departmentid == -1)
            {
                throw new Exception("未选择员工所在部门");
            }
        }

        //员工部门交换 ?? 功能重复
        public static void SwitchDepartment(int employeeId, int departmentId)
        {
            Employee employee = new Employee();
            employee.em_id = employeeId;
            employee.em_departmentid = departmentId;
            employee.Update();
        }

        //员工查询 ？？sql的的生成
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
    }
}
