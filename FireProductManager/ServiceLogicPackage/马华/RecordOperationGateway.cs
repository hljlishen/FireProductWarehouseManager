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

        public static DataTable GetAllOutRecord()
        {
            SelectSqlMaker maker = new SelectSqlMaker("outrecord");
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        public static DataTable GetAllInRecord()
        {
            SelectSqlMaker maker = new SelectSqlMaker("inrecord");
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

        public static DataTable ThroughProjectIdQuery(int id)
        {
            SelectSqlMaker maker = new SelectSqlMaker("project");
            maker.AddAndCondition(new IntEqual("pr_id", id));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        public static DataTable ThroughOutRecordIdQuery(int outId)
        {
            SelectSqlMaker maker = new SelectSqlMaker("outrecord");
            maker.AddAndCondition(new IntEqual("or_id", outId));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        //借包
        public static void BorrowPackage(int packageid,int employeeid,int projectId,string borrowName,string accountName,double outWeight)
        {
            PackageGateway.BorrowPackage(packageid);

            OutRecord outRecord = new OutRecord();
            outRecord.or_packageId = packageid; 
            outRecord.or_employeeId = employeeid;
            outRecord.or_projectId = projectId;
            outRecord.or_borrowName = borrowName;
            outRecord.or_accountName = accountName;
            outRecord.or_direction = "出库";
            outRecord.or_timeStmp = DateTime.Now;
            outRecord.or_outWeight = outWeight;
            outRecord.Insert();
        }

        //还包
        public static void ReturnPackage(int outid,int packageid,int barrelid, string accountName,double consumption, double returnWeight,double packageTare)
        {
            PackageGateway.ReturnPackage(packageid, barrelid, returnWeight);

            InRecord inRecord = new InRecord();
            inRecord.ir_outid = outid;
            inRecord.ir_accountName = accountName;
            inRecord.ir_direction = "入库";
            inRecord.ir_timeStmp = DateTime.Now;
            inRecord.ir_consumption = consumption;
            inRecord.ir_returnWeight = returnWeight;
            inRecord.ir_packageTare = packageTare;
            inRecord.Insert();  
        }

        //判断packageid是否存在
        public static bool IsPackageIdValid(int packageid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_id", packageid));
            DataTable dt = Query(maker.MakeSelectSql());
            return dt.Rows.Count > 0;
        }

        //出库条件搜索
        public static DataTable ConditionsSearchOutRecord(string packageId,string employeeId,string projectId,string direction,bool isChoiceTime,DateTime begintTime,DateTime endTime)
        {
            SelectSqlMaker maker = new SelectSqlMaker("outrecord");
            maker.AddAndCondition(new StringEqual("or_packageId", packageId));
            maker.AddAndCondition(new StringEqual("or_employeeId", employeeId));
            maker.AddAndCondition(new IntEqual("or_projectId", projectId));
            if (direction == "出入库")
                maker.AddAndCondition(new StringLike("or_direction", "库"));
            else
                maker.AddAndCondition(new StringEqual("or_direction", direction));
            if (isChoiceTime)
                maker.AddAndCondition(new DateBetweenOpenInterval("or_timeStmp", begintTime, endTime,DbLinkManager.databaseType));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        //入库条件搜索
        public static DataTable ConditionsSearchInRecord(string outid,string direction, bool isChoiceTime, DateTime begintTime, DateTime endTime)
        {
            SelectSqlMaker maker = new SelectSqlMaker("inrecord");
            maker.AddAndCondition(new StringEqual("ir_outid", outid));
            if (direction == "出入库")
                maker.AddAndCondition(new StringLike("ir_direction", "库"));
            else
                maker.AddAndCondition(new StringEqual("ir_direction", direction));
            if (isChoiceTime)
                maker.AddAndCondition(new DateBetweenOpenInterval("ir_timeStmp", begintTime, endTime, DbLinkManager.databaseType));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        public static DataTable ConditionsSearchOutId(string packageId, string employeeId, string projectId)
        {
            SelectSqlMaker maker = new SelectSqlMaker("outrecord");
            maker.AddAndCondition(new StringEqual("or_packageId", packageId));
            maker.AddAndCondition(new StringEqual("or_employeeId", employeeId));
            maker.AddAndCondition(new IntEqual("or_projectId", projectId));
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

        public static DataTable ThroughPackageIdQueryoutrecord(int packageId)
        {
            SelectSqlMaker maker = new SelectSqlMaker("outrecord");
            maker.AddAndCondition(new IntEqual("or_packageId", packageId));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        public static DataTable SelectInRecord()
        {
            SelectSqlMaker maker = new SelectSqlMaker("inrecord");
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }
    }
}
