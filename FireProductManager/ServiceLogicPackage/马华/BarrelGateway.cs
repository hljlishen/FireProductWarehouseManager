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
    class BarrelGateway
    {
        //查询桶
        public static DataTable Query(string sql)
        {
            Barrel barrel = new Barrel();
            var queryBarrel = barrel.Select(sql);
            return queryBarrel;
        }

        //记录新桶
        public static Barrel RecordNewBarrel()
        {
            Barrel barrel = new Barrel();
            barrel.Ba_IsRemoved = 0; //0为存在，1为不存在
            barrel.Insert();
            barrel.Ba_Id = FindAvailableBarrelId();
            return barrel;
        }

        //删除桶
        public static bool RemoveBarrel(int barrelid)
        {
            Barrel barrel = new Barrel();
            barrel.Ba_Id = barrelid;
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
            Package package = new Package();
            maker.AddAndCondition(new IntEqual("pa_barrelId",barrelid));
            string sql = maker.MakeSelectSql();
            DataTable dt = package.Select(sql);
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
            Barrel barrel = new Barrel();
            maker.AddAndCondition(new IntEqual("Ba_IsRemoved",0));
            string sql = maker.MakeSelectSql();
            DataTable dt = barrel.Select(sql);

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
            maker.AddAndCondition(new IntEqual("ba_Id", barrelid));
            Barrel barrel = new Barrel();
            string sql = maker.MakeSelectSql();
            DataTable dt = barrel.Select(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
