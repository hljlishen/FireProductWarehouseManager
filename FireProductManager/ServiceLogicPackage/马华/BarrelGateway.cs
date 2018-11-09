using DbLink;
using FireProductManager.EntityPackage;
using System.Data;

namespace FireProductManager.ServiceLogicPackage
{
    class BarrelGateway
    {
        //查询桶
        public static DataTable Query(string sql)
        {
            var queryBarrel = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return queryBarrel;
        }

        //记录新桶
        public static Barrel RecordNewBarrel()
        {
            Barrel barrel = new Barrel();
            barrel.ba_isRemoved = 0; //0为存在，1为不存在
            barrel.Insert();
            barrel.ba_id = FindAvailableBarrelId();
            return barrel;
        }

        //删除桶
        public static bool RemoveBarrel(int barrelid)
        {
            Barrel barrel = new Barrel();
            barrel.ba_id = barrelid;
            if (IsBarrelIdValid(barrelid))
            {
                barrel.Delete();
                return true;
            }
            return false;
        }

        //全重
        public static double WeightOfBarrel(int barrelid)
        {
            double weigth = 0;
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_barrelId", barrelid));
            string sql = maker.MakeSelectSql();
            DataTable dt = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);

            foreach (DataRow dr in dt.Rows)
            {
                weigth += double.Parse(dr["pa_weight"].ToString());
            }
            return weigth;
        }

        //找到可用的桶id
        private static int FindAvailableBarrelId()
        {
            int barrelid = 0;
            SelectSqlMaker maker = new SelectSqlMaker("barrel");
            maker.AddAndCondition(new IntEqual("ba_isRemoved",0));
            string sql = maker.MakeSelectSql();
            DataTable dt = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);

            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i<dt.Rows.Count;i++)
                {
                    barrelid = int.Parse(row["ba_id"].ToString());
                }
            }
            return barrelid;
        }

        //判断桶id是否存在
        private static bool IsBarrelIdValid(int barrelid)
        {
            SelectSqlMaker maker = new SelectSqlMaker("barrel");
            maker.AddAndCondition(new IntEqual("ba_id", barrelid));
            DataTable dt = ActiveRecord.Select(maker.MakeSelectSql(), DbLinkManager.databaseType, DbLinkManager.connectString);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
