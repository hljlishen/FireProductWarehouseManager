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
        public static void UpdateProject(uint id, string name, string projectPassword, string note)
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
            project.pr_id = (uint)projectId;
            project.Delete();
        }
    }
}
