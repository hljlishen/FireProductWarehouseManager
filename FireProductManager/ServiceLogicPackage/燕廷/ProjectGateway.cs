using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage.燕廷
{
    class ProjectGateway
    {
        //获取全部项目
        public static DataTable GetAllProject()
        {
            Project project = new Project();
            SelectSqlMaker maker = new SelectSqlMaker("project");
            return Query(maker.MakeSelectSql());
        }

        //项目搜索
        public static DataTable GetQueryEmployees(string employeenumber, string name, string sex)
        {
            if (sex.Equals("男/女")) sex = "";
            if (employeenumber.Equals("") && name.Equals("") && sex.Equals(""))
            {
                DataTable dataTable = GetAllProject();
                return dataTable;
            }
            SelectSqlMaker maker = new SelectSqlMaker("employee");
            maker.AddAndCondition(new StringLike("em_employeenumber", employeenumber));
            maker.AddAndCondition(new StringLike("em_name", name));
            maker.AddAndCondition(new StringLike("em_sex", sex));
            return Query(maker.MakeSelectSql());
        }

        //项目查询 
        private static DataTable Query(string sql)
        {
            DataTable dataTable = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return dataTable;
        }
    }
}
