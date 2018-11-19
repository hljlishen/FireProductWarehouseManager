using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Data;

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
            inOutRecord.ior_packageId = (uint)packageid;
            inOutRecord.ior_employeeId = (uint)employeeid;
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
            inOutRecord.ior_packageId = (uint)packageid;
            inOutRecord.ior_employeeId = (uint)employeeid;
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
            return dt.Rows.Count > 0;
        }
    }
}
