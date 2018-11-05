using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage
{
    class BarrelGateway
    {

        //查询桶
        public static List<Barrel> Query(string sql)
        {
            List<Barrel> barrels = new List<Barrel>();
            return barrels;
        }

        //记录新桶
        public static Barrel RecordNewBarrel()
        {
            Barrel barrel = new Barrel();
            return barrel;
        }

        //删除桶
        public static bool RemoveBarrel(int barrelid)
        {
            return true;
        }

        //获取全部型号
        public static List<string> GetAllModels(int id)
        {
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
            return 1;
        }
    }
}
