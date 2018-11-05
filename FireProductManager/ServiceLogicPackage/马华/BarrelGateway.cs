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
        static DbLinkFactory factory;
        //查询桶
        public static List<Barrel> Query(string sql)
        {
            Barrel barrel = new Barrel();
            List<Barrel> barrels = new List<Barrel>();
            //var queryresult = Barrel.Select(sql,);
            return barrels;
        }

        //记录新桶
        public static Barrel RecordNewBarrel(int Ba_Id,int Ba_IsRemoved)
        {
            SelectSqlMaker maker = new SelectSqlMaker("Barrel");
            Barrel barrel = new Barrel();
            barrel.Ba_Id = Ba_Id;
            barrel.Ba_IsRemoved = Ba_IsRemoved;
            return barrel;
        }

        //删除桶
        public static bool RemoveBarrel(int barrelid)
        {
            Barrel barrel = new Barrel();
            barrel.Ba_Id = barrelid;
            string sql = "delete from barrel where ba_id = " + barrel.Ba_Id + "";

            return true;
        }

        //获取全部型号
        public static List<string> GetAllModels(int id)
        {
            SelectSqlMaker maker = new SelectSqlMaker("Package");

            List<string> allModel = new List<string>();
            return allModel;
        }

        //统计权重
        public static Dictionary<string, double> StatisticWeights(int id)
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            return keyValuePairs;
        }

        //权重
        public static double Weight(int id)
        {
            return id;
        }

        //找到可用的桶id
        public static int FindAvailableBarrelId()
        {
            SelectSqlMaker maker = new SelectSqlMaker("Barrel");
            Barrel barrel = new Barrel();
            string sql = maker.MakeSelectSql();
            return 1;
        }
    }
}
