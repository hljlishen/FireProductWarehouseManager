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
    public class RecordOperationGateway
    {
        public static DataTable Query(string sql)
        {
            var query = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return query;
        }

        //借包
        public static void BorrowPackage(int packageid)
        {
            if (IsPackageIdValid(packageid))
            {
                Package package = new Package();
                package.pa_id = packageid;
                package.pa_isinWarehouse = 1;
                package.Update();
            }    
        }

        //还包
        public static void ReturnPackage(int packageid,int barrelid)
        {
            if (IsPackageIdValid(packageid))
            {
                Package package = new Package();
                package.pa_id = packageid;
                package.pa_isinWarehouse = 0;
                package.pa_barrelId = barrelid;
                package.Update();
            }
        }

        //判断包id是否存在
        private static bool IsPackageIdValid(int packageid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_id", packageid));
            DataTable dt = ActiveRecord.Select(maker.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
