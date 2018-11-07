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
    class AccountManager
    {
        private static Account account;

        public static bool Login(string accounts,string password)
        {
            SelectSqlMaker maker = new SelectSqlMaker("account");
            maker.AddAndCondition(new StringEqual("Ac_Accounts",accounts));
            maker.AddAndCondition(new StringEqual("Ac_Password",password));
            string sql = maker.MakeSelectSql();
            DataTable dt = account.Select(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (int.Parse(dr["Ac_Authority"].ToString()) == 1)//1为超级管理员权限，可写可读，2为普通管理员权限，可读不可写
                    {
                        CanReadDatabase();
                        CanWriteDatabase();
                    }
                    else
                        CanReadDatabase();
                    return true;
                }
            }
            return false;
        }

        public static void Logout()
        {

        }

        public static bool CanReadDatabase()
        {
            return true;
        }

        public static bool CanWriteDatabase()
        {
            return true;
        }
    }
}
