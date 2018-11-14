using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FireProductManager.ServiceLogicPackage
{
    class PackageGateway
    {
        //材料查询
        public static DataTable Query(string sql)
        {
            DataTable dataTable = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return dataTable;
        }

        //包放入桶中
        public static void PutPackageIntoBarrel(int packageId, int barrelId)
        {
            Package package = new Package();
            package.pa_id = packageId;
            package.pa_barrelId = barrelId;
            if (!HasBarrel(barrelId)) throw new Exception("不存在该桶");
            package.Update();
        }

        //该桶是否存在
        private static bool HasBarrel(int barrelId)
        {
            SelectSqlMaker maker = new SelectSqlMaker("barrel");
            maker.AddAndCondition(new IntEqual("ba_id", barrelId));
            DataTable dataTable = ActiveRecord.Select(maker.MakeSelectSql(),DbLinkManager.databaseType,DbLinkManager.connectString);
            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        //获取仓库全部的材料类型 
        public static List<string> GetAllModelsInWarehouse()
        {
            List<string> list = new List<string>();
            Package package = new Package();
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            DataTable dataTable = package.Select(maker.MakeSelectSql());

            foreach (DataRow dr in dataTable.Rows)
            {
                foreach (string model in list)
                {
                    if (!model.Equals((string)dr["pa_modle"]))
                    {
                        list.Add((string)dr["pa_modle"]);
                    }
                }
            }

            return list;
        }

        //获取仓库全部材料的类型与重量
        public static Dictionary<string, double> StatisticAllModelWeightsInWarehouse()
        {
            Package package = new Package();
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            DataTable dataTable = package.Select(maker.MakeSelectSql());
            Dictionary<string, double> keyValuePairs = GetModleOfWeight(dataTable);
            return keyValuePairs;
        }

        //获取桶中材料的类型
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

        //获取桶中材料的类型与重量
        public static Dictionary<string, double> StatisticModelsWeightInBarrel(int barrelId)
        {
            Package package = new Package();
            package.pa_barrelId = barrelId;
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            maker.AddAndCondition(new IntEqual("pa_id", package.pa_barrelId.Value));
            DataTable dataTable = package.Select(maker.MakeSelectSql());
            Dictionary<string, double> keyValuePairs = GetModleOfWeight(dataTable);
            return keyValuePairs;
        }

        //获取材料的重量
        private static Dictionary<string, double> GetModleOfWeight(DataTable dataTable)
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            foreach (DataRow dr in dataTable.Rows)  
            {
                string key = (string)dr["pa_modle"];
                if (keyValuePairs.Keys.Contains(key))
                {
                    keyValuePairs[key] += (double)dr["em_weight"];
                }
                else
                {
                    keyValuePairs.Add((string)dr["pa_modle"], (double)dr["em_weight"]);
                }
            }
            return keyValuePairs;
        }

        internal static void ReturnPackage(int packageid, int barrelid)
        {
            Package package = new Package();
            package.pa_id = packageid;
            package.pa_isinWarehouse = 0;
            package.pa_barrelId = barrelid;
            package.Update();
        }

        internal static void BorrowPackage(int packageid)
        {
            Package package = new Package();
            package.pa_id = packageid;
            package.pa_isinWarehouse = 1;
            package.Update();
        }
    }
}
