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
    class PackageGateway
    {
        public static List<Package> Query(string sql)
        {
            List<Package> list = new List<Package>();
            return list;
        }

        public static void PutPackageIntoBarrel(int packageId, int barrelId)
        {

        }

        public static List<Package> GetAllModelsInWarehouse()
        {
            List<Package> list = new List<Package>();
            return list;
        }

        public static Dictionary<string,double> StatisticAllModelWeightsInWarehouse()
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            return keyValuePairs;
        }


        public static List<string> GetAllModelsInBarrelId(int barrelid)
        {
            List<string> allModel = new List<string>();
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            maker.AddAndCondition(new IntEqual("pa_barrelId", barrelid));
            Package package = new Package();
            DataTable dt = package.Select(maker.MakeSelectSql());

            foreach (DataRow dr in dt.Rows)
            {
                string model = dr["pa_modle"].ToString();
                if (allModel.Contains(model))
                    continue;
                allModel.Add(model);
            }

            return allModel;
        }

        public static Dictionary<string, double> StatisticModelsWeightInBarrel(int barrelid)
        {
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            Package package = new Package();
            package.pa_barrelId = barrelid;

            return dictionary;
        }
    }
}
