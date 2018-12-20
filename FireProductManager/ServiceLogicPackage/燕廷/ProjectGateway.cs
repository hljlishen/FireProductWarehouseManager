using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage
{
    public class ProjectGateway
    {
        //获取全部项目
        public static DataTable GetAllProject()
        {
            Project project = new Project();
            SelectSqlMaker maker = new SelectSqlMaker("project");
            return Query(maker.MakeSelectSql());
        }

        //项目搜索
        public static DataTable GetQueryProject(string name, string projectPassword)
        {
            if (name.Equals("") && name.Equals("") && projectPassword.Equals(""))
            {
                DataTable dataTable = GetAllProject();
                return dataTable;
            }
            SelectSqlMaker maker = new SelectSqlMaker("project");
            maker.AddAndCondition(new StringLike("pr_name", name));
            maker.AddAndCondition(new StringLike("pr_projectpassword", projectPassword));
            return Query(maker.MakeSelectSql());
        }

        //项目查询 
        private static DataTable Query(string sql)
        {
            DataTable dataTable = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return dataTable;
        }

        //添加项目 
        public static void NewProject(string name, string projectPassword, string note)
        {
            Project project = new Project();
            project.pr_name = name;
            project.pr_projectPassword = projectPassword;
            project.pr_note = note;
            project.Insert();
        }

        //修改项目
        public static void UpdateProject(int id, string name, string projectPassword, string note)
        {
            Project project = new Project();
            project.pr_id = id;
            project.pr_name = name;
            project.pr_projectPassword = projectPassword;
            project.pr_note = note;
            project.Update();
        }

        //删除项目
        public static void DeleteProject(int projectId)
        {
            Project project = new Project();
            project.pr_id = projectId;
            project.Delete();
        }

        //获取项目信息
        public static DataTable GetProjectInformation(int projectid)
        {
            Project project = new Project();
            SelectSqlMaker maker = new SelectSqlMaker("project");
            maker.AddAndCondition(new IntEqual("pr_id",projectid));
            DataTable dataTable = project.Select(maker.MakeSelectSql());
            return dataTable;
        }

        //添加-验证Projectpassword
        public static bool NewValidationProjectPassWord(string projectpassword)
        {
            SelectSqlMaker maker = new SelectSqlMaker("project");
            maker.AddAndCondition(new StringEqual("pr_projectpassword", projectpassword));
            DataTable dataTable = ActiveRecord.Select(maker.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dataTable.Rows.Count != 0)
            {
                return false;
            }
            return true;
        }

        //更新-验证Projectpassword
        public static bool UpdateValidationProjectPassWord(int projectid, string projectpassword)
        {
            SelectSqlMaker maker = new SelectSqlMaker("project");
            maker.AddAndCondition(new IntEqual("pr_id", projectid));
            DataTable dataTable = ActiveRecord.Select(maker.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            Project project = new Project();
            project.LoadDataRow(dataTable.Rows[0]);
            if (project.pr_projectPassword.Equals(projectpassword)) return true;

            SelectSqlMaker maker1 = new SelectSqlMaker("project");
            maker.AddAndCondition(new StringEqual("pr_projectpassword", projectpassword));
            DataTable dataTable1 = ActiveRecord.Select(maker1.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dataTable1.Rows.Count != 0)
            {
                return false;
            }
            return true;
        }

        //获取项目令号
        public static string GetProjectPassword(int projectid)
        {
            DataTable dataTable = GetProjectInformation(projectid);
            DataRow myDr = dataTable.Rows[0];
            return myDr["pr_projectpassword"].ToString();
        }
    }
}
