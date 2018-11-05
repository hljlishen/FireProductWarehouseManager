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
            var queryresult = barrel.Select(sql);
            List<Barrel> ret = new List<Barrel>();

            foreach(var row in queryresult.Rows)
            {
                Barrel b = new Barrel();
                b.LoadDataRow((DataRow)row);
                ret.Add(b);
            }

            return ret;
        }

        //记录新桶
        public static Barrel RecordNewBarrel()
        {
            int id = FindAvailableBarrelId();
            Barrel barrel = new Barrel();
            barrel.Ba_Id = id;
            barrel.Ba_IsRemoved = 0;
            barrel.Insert();
            return barrel;
        }

        //删除桶
        public static bool RemoveBarrel(int barrelid)
        {
            Barrel barrel = new Barrel();
            barrel.Ba_Id = barrelid;
            //string sql = "delete from barrel where ba_id = " + barrel.Ba_Id + "";
            barrel.Delete();

            return true;
        }

        //获取全部型号
        public static List<string> GetAllModelsInBarrel(int barrelId)
        {
            List<string> allModel = new List<string>();
            return allModel;
        }

        //统计权重
        public static Dictionary<string, double> StatisticWeights(int barrelId)
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            return keyValuePairs;
        }

        //权重
        public static double TotalWeight(int barrelId)
        {

            return 0;
        }

        //找到可用的桶id
        private static int FindAvailableBarrelId()
        {
            Barrel barrel = new Barrel();
            return 1;
        }
    }
}
