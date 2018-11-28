using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Data;

namespace FireProductManager.ServiceLogicPackage
{
    public class RecordOperationGateway
    {
        private static DataTable Query(string sql)
        {
            var query = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return query;
        }

        public static DataTable GetAllInOrOutRecord()
        {
            SelectSqlMaker maker = new SelectSqlMaker("inoutrecord");
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        public static DataTable ThroughPackageIdQuery(int packageId)
        {
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_id", packageId));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        //借包
        public static void BorrowPackage(int packageid,int employeeid,int projectId,string borrowName,string accountName)
        {
            PackageGateway.BorrowPackage(packageid);

            InOutRecord inOutRecord = new InOutRecord();
            inOutRecord.ior_packageId = (uint)packageid;
            inOutRecord.ior_employeeId = (uint)employeeid;
            inOutRecord.ior_projectId = (uint)projectId;
            inOutRecord.ior_borrowName = borrowName;
            inOutRecord.ior_accountName = accountName;
            inOutRecord.ior_direction = "出库";
            inOutRecord.ior_timeStmp = DateTime.Now;
            inOutRecord.Insert();
        }

        //还包
        public static void ReturnPackage(int packageid,int barrelid,int employeeid, int projectId, string borrowName, string accountName)
        {
            PackageGateway.ReturnPackage(packageid, barrelid);

            InOutRecord inOutRecord = new InOutRecord();
            inOutRecord.ior_packageId = (uint)packageid;
            inOutRecord.ior_employeeId = (uint)employeeid;
            inOutRecord.ior_projectId = (uint)projectId;
            inOutRecord.ior_borrowName = borrowName;
            inOutRecord.ior_accountName = accountName;
            inOutRecord.ior_direction = "入库";
            inOutRecord.ior_timeStmp = DateTime.Now;
            inOutRecord.Insert();  
        }

        //判断packageid是否存在
        public static bool IsPackageIdValid(int packageid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_id", packageid));
            DataTable dt = ActiveRecord.Select(maker.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            return dt.Rows.Count > 0;
        }

        public static DataTable ConditionsSearchInOrOutRecord(string packageId,string employeeId,string projectId,string direction,bool isChoiceTime,DateTime begintTime,DateTime endTime)
        {
            SelectSqlMaker maker = new SelectSqlMaker("inoutrecord");
            maker.AddAndCondition(new StringEqual("ior_packageId", packageId));
            maker.AddAndCondition(new StringEqual("ior_employeeId", employeeId));
            maker.AddAndCondition(new StringEqual("ior_projectId", projectId));
            if (direction == "出入库")
                maker.AddAndCondition(new StringLike("ior_direction", "库"));
            else
                maker.AddAndCondition(new StringEqual("ior_direction", direction));
            if(isChoiceTime)
                maker.AddAndCondition(new DateBetweenOpenInterval("ior_timeStmp", begintTime, endTime,DbLinkManager.databaseType));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        public static int IsinWarehouse(int packageId)
        {
            int inWarehouse = 0;
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_id", packageId));
            DataTable dt = ActiveRecord.Select(maker.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            foreach (DataRow dr in dt.Rows)
                inWarehouse = (int)dr["pa_isinWarehouse"];
            return inWarehouse;
        }
    }
}
