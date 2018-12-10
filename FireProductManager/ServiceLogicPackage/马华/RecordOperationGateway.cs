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

        public static DataTable ThroughPackageIdQuerypackage(int packageId)
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
        public static void ReturnPackage(int packageid,int barrelid,int employeeid, int projectId, string borrowName, string accountName,double weight)
        {
            PackageGateway.ReturnPackage(packageid, barrelid, weight);

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
            DataTable dt = Query(maker.MakeSelectSql());
            return dt.Rows.Count > 0;
        }

        //条件搜索
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

        //判断袋子是否在库
        public static bool IsinWarehouse(int packageId)
        {
            int inWarehouse = 0;
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_id", packageId));

            foreach (DataRow dr in Query(maker.MakeSelectSql()).Rows)
                inWarehouse = (int)dr["pa_isinWarehouse"];
            return inWarehouse == 0;
        }

        public static DataTable ThroughPackageIdQueryinoutrecord(int packageId)
        {
            SelectSqlMaker maker = new SelectSqlMaker("inoutrecord");
            maker.AddAndCondition(new IntEqual("ior_packageId", packageId));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }
    }
}
