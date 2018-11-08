using FireProductManager.EntityPackage;
using System;
using DbLink;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FireProductManager.ServiceLogicPackage
{
    public class AccountManager
    {
        private static Account account;

        public static bool Login(string accounts,string password)
        {
            if (IsAccountValid(accounts, password))
                return true;
            return false;
        }

        //??
        public static void Logout()
        {
            
        }

        public static bool CanReadDatabase()
        {
            account = new Account();
            if (account.ac_authority == 1 || account.ac_authority == 2)//1为超级管理员，2为普通管理员
                return true;
            return false;
        }

        public static bool CanWriteDatabase()
        {
            account = new Account();
            if (account.ac_authority == 1)
                return true;
            return false;
        }

        private static bool IsAccountValid(string accounts, string password)
        {
            SelectSqlMaker maker = new SelectSqlMaker("account");
            maker.AddAndCondition(new StringEqual("ac_account", accounts));
            maker.AddAndCondition(new StringEqual("ac_password", password));
            string sql = maker.MakeSelectSql();
            DataTable dt = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
