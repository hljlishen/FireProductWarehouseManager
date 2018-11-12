using DbLink;
using FireProductManager.EntityPackage;
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

        //注销的方式
        public static void Logout()
        {
            Form1 form = new Form1();
            form.Close();
            Application.Exit();
        }

        public static bool CanReadDatabase()
        {
            if (account.ac_authority == 1 || account.ac_authority == 2)//1为超级管理员，2为普通管理员
                return true;
            return false;
        }

        public static bool CanWriteDatabase()
        {
            if (account.ac_authority == 1)
                return true;
            return false;
        }

        private static bool IsAccountValid(string accounts, string password)    //????????????函数没有意义，应该对account赋值
        {
            SelectSqlMaker maker = new SelectSqlMaker("account");
            maker.AddAndCondition(new StringEqual("ac_account", accounts));
            maker.AddAndCondition(new StringEqual("ac_password", password));
            string sql = maker.MakeSelectSql();
            DataTable dt = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dt.Rows.Count > 0)
            {
                //GetAdministratorAuthorityLevel(accounts,password);
                account = new Account();
                account.LoadDataRow(dt.Rows[0]);
                return true;
            }  
            return false;
        }

        private static void GetAdministratorAuthorityLevel(string accounts, string password)    //不应每次查询数据库
        {
            int authorityLevel = 0;
            SelectSqlMaker maker = new SelectSqlMaker("account");
            maker.AddAndCondition(new StringEqual("ac_account", accounts));
            maker.AddAndCondition(new StringEqual("ac_password", password));
            string sql = maker.MakeSelectSql();
            DataTable dt = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);

            foreach (DataRow dr in dt.Rows)
            {
                authorityLevel = int.Parse(dr["ac_authority"].ToString());
                account = new Account();
                account.ac_authority = authorityLevel;
            }
        }
    }
}
