using DbLink;
using FireProductManager.EntityPackage;
using FireProductManager.GuiPackage;
using System.Data;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    public class AccountManager
    {
        private static Account account;

        public static bool Login(string accounts,string password)
        {
            return IsAccountValid(accounts, password);
        }

        public static void Logout()
        {
            account = null;
        }

        public static bool CanReadDatabase()
        {
            return (account.ac_authority == 1 || account.ac_authority == 2);//1为超级管理员，2为普通管理员
        }

        public static bool CanWriteDatabase()
        {
            return (account.ac_authority == 1);
        }

        private static bool IsAccountValid(string accounts, string password)
        {
            SelectSqlMaker maker = new SelectSqlMaker("account");
            maker.AddAndCondition(new StringEqual("ac_account", accounts));
            maker.AddAndCondition(new StringEqual("ac_password", password));
            string sql = maker.MakeSelectSql();
            DataTable dt = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dt.Rows.Count > 0)
            {
                account = new Account();
                account.LoadDataRow(dt.Rows[0]);//改为uint后loaddatarow不支持
                return true;
            }  
            return false;
        }
    }
}
