using DbLink;
using FireProductManager.EntityPackage;
using System.Data;

namespace FireProductManager.ServiceLogicPackage
{
    public class BarrelGateway
    {
        //查询桶
        private static DataTable Query(string sql)
        {
            var queryBarrel = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return queryBarrel;
        }

        public static DataTable BarrelIdQueryPackageInformation(int barrelid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_barrelId", barrelid));
            maker.AddAndCondition(new IntEqual("pa_isinWarehouse", 0));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        public static DataTable NoRemoveBarrelId()
        {
            SelectSqlMaker maker = new SelectSqlMaker("barrel");
            maker.AddAndCondition(new IntEqual("ba_isRemoved", 0));
            string sql = maker.MakeSelectSql();
            return Query(sql);
        }

        //记录新桶
        public static int RecordNewBarrel()
        {
            Barrel barrel = new Barrel();//id自加
            barrel.ba_isRemoved = 0; //0为存在，1为不存在
            barrel.Insert();
            barrel.ba_id = (uint)FindMaxBarrelId();
            return (int)barrel.ba_id;
        }

        //删除桶
        public static bool RemoveBarrel(int barrelid)
        {
            if (!IsBarrelIdValid(barrelid)) return false;

            Barrel barrel = new Barrel();
            barrel.ba_id = (uint)barrelid;
            barrel.ba_isRemoved = 1;
            barrel.Update();
            return true;
        }

        //全重
        public static double WeightOfBarrel(int barrelid)
        {
            double weigth = 0;
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_barrelId", barrelid));
            maker.AddAndCondition(new IntEqual("pa_isinWarehouse", 0));
            string sql = maker.MakeSelectSql();
            DataTable dt = Query(sql);

            foreach (DataRow dr in dt.Rows)
                weigth += double.Parse(dr["pa_weight"].ToString());

            return weigth;
        }

        //找到最大一个桶的id
        private static int FindMaxBarrelId()
        {
            SelectSqlMaker maker = new SelectSqlMaker("barrel");
            string sql = maker.MakeSelectMaxSql("ba_id");
            DataTable dt = Query(sql);
            int barrelid = int.Parse(dt.Rows[0][0].ToString());
            return barrelid;
        }

        //判断桶id是否存在
        private static bool IsBarrelIdValid(int barrelid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("barrel");
            maker.AddAndCondition(new IntEqual("ba_id", barrelid));
            DataTable dt = Query(maker.MakeSelectSql());
            return dt.Rows.Count > 0;
        }

        //判断桶中是否存在pa_isinWarehouse为1的袋子
        public static bool IsBarrelInExistPackage(int barrelid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_barrelId",barrelid));
            maker.AddAndCondition(new IntEqual("pa_isinWarehouse", 0));
            DataTable dt = Query(maker.MakeSelectSql());
            return dt.Rows.Count > 0;
        }

        //找到的桶内重量不足桶id
        public static int SearchShortweightBarrrelId()
        {
            int barrelId = 0;
            foreach (DataRow dr in NoRemoveBarrelId().Rows)
            {
                barrelId = (int)dr["ba_id"];
                if (WeightOfBarrel(barrelId) < 300)
                    return barrelId;
            }
            return  barrelId;
        }
    }
}
