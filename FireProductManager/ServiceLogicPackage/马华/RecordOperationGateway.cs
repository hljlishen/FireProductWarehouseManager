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
        public static void BorrowPackage(int packageid,int employeeid)
        {
            if (!IsPackageIdValid(packageid)) return;

            PackageGateway.BorrowPackage(packageid);

            InOutRecord inOutRecord = new InOutRecord();
            inOutRecord.ior_packageId = packageid;
            inOutRecord.ior_employeeId = employeeid;
            inOutRecord.ior_direction = "出库";
            inOutRecord.ior_timeStmp = DateTime.Now;
            inOutRecord.Insert();
        }

        //还包
        public static void ReturnPackage(int packageid,int barrelid,int employeeid)
        {
            if (!IsPackageIdValid(packageid)) return;
            
            PackageGateway.ReturnPackage(packageid, barrelid);

            InOutRecord inOutRecord = new InOutRecord();
            inOutRecord.ior_packageId = packageid;
            inOutRecord.ior_employeeId = employeeid;
            inOutRecord.ior_direction = "入库";
            inOutRecord.ior_timeStmp = DateTime.Now;
            inOutRecord.Insert();  
        }

        //判断packageid是否存在
        private static bool IsPackageIdValid(int packageid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_id", packageid));
            DataTable dt = ActiveRecord.Select(maker.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
