using DbLink;
using FireProductManager.EntityPackage;
using System.Data;

namespace FireProductManager.ServiceLogicPackage
{
    public class AccountManager
    {
        private static Account account;

        public static bool Login(string accounts,string password)
        {
            SelectSqlMaker maker = new SelectSqlMaker("account");
            maker.AddAndCondition(new StringEqual("ac_accountNumber", accounts));
            maker.AddAndCondition(new StringEqual("ac_password", password));
            string sql = maker.MakeSelectSql();
            DataTable dt = Query(sql);
            if (dt.Rows.Count > 0)
            {
                account = new Account();
                account.LoadDataRow(dt.Rows[0]);//改为uint后loaddatarow不支持
                return true;
            }
            return false;
        }

        public static void Logout() => account = null;

        public static bool CanReadDatabase()     //用不到
=> (account.ac_authority == 1 || account.ac_authority == 2);//1为超级管理员，2为普通管理员

        public static bool CanWriteDatabase() => account.ac_authority == 1;

        private static DataTable Query(string sql)
        {
            var queryBarrel = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return queryBarrel;
        }

        public static DataTable GetAllAccountInformation()
        {
            SelectSqlMaker maker = new SelectSqlMaker("account");
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        public static bool RemoveAccount(int accountid)
        {
            if (!IsAccountIdValid(accountid)) return false;

            Account account = new Account();
            account.ac_id = accountid;
            account.Delete();
            return true;
        }

        private static bool IsAccountIdValid(int accountid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("account");
            maker.AddAndCondition(new IntEqual("ac_id",accountid));
            string sql = maker.MakeSelectSql();
            DataTable dt = Query(sql);
            return dt.Rows.Count > 0;
        }

        public static void AddAccount(string accounts,string name ,string password,int authority)
        {
            Account account = new Account();
            account.ac_accountNumber = accounts;
            account.ac_accountName = name;
            account.ac_password = password;
            account.ac_authority = authority;
            account.Insert();
        }

        public static void UpdateAccount(int accountid,string accounts,string name ,string password, int authority)
        {
            Account account = new Account();
            account.ac_id = accountid;
            account.ac_accountNumber = accounts;
            account.ac_accountName = name;
            account.ac_password = password;
            account.ac_authority = authority;
            account.Update();
        }

        public static string ReturnAccount()
        {
            if (account == null) return null;
            return account.ac_accountName;
        }

        public static bool IsAccountNumberValid(string accountNumber)
        {
            SelectSqlMaker maker = new SelectSqlMaker("account");
            maker.AddAndCondition(new StringEqual("ac_accountNumber", accountNumber));
            string sql = maker.MakeSelectSql();
            DataTable dt = Query(sql);
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
