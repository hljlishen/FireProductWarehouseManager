using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Data;

namespace FireProductManager.ServiceLogicPackage
{
    class PackageGateway
    {
        //材料查询
        public static List<Package> Query(string sql)
        {
            DataTable dataTable = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            List<Package> list = new List<Package>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Package p = new Package();
                p.LoadDataRow(dr);
                list.Add(p);
            }
            return list;
        }

        //包放入桶中
        public static void PutPackageIntoBarrel(int packageId, int barrelId)
        {
            Package package = new Package();
            package.pa_id = packageId;
            package.pa_barrelId = barrelId;
            HasBarrel(barrelId);
            package.Update();
        }

        //该桶是否存在
        private static void HasBarrel(int barrelId)
        {
            SelectSqlMaker maker = new SelectSqlMaker("barrel");
            maker.AddAndCondition(new IntEqual("ba_id", barrelId));
            DataTable dataTable = ActiveRecord.Select(maker.MakeSelectSql(),DbLinkManager.databaseType,DbLinkManager.connectString);
            if (dataTable.Rows.Count == 0)
            {
                throw new Exception("不存在该小组");
            }
            return;
        }

        //获取仓库全部的材料类型 ？？model与Package冲突
        public static List<Package> GetAllModelsInWarehouse()
        {
            List<Package> list = new List<Package>();

            Package package = new Package();
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            DataTable dataTable = package.Select(maker.MakeSelectSql());

            foreach (DataRow dr in dataTable.Rows)
            {
                Package p = new Package();
                p.LoadDataRow(dr);
                list.Add(p);
            }

            return list;
        }

        //获取仓库全部材料的类型与重量
        public static Dictionary<string,double> StatisticAllModelWeightsInWarehouse()
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();

            Package package = new Package();
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            DataTable dataTable = package.Select(maker.MakeSelectSql());

            foreach (DataRow dr in dataTable.Rows)
            {
                Dictionary<string, double>.KeyCollection keyCol = keyValuePairs.Keys;
                foreach (string key in keyCol)
                {
                    if (key.Equals((string)dr["pa_modle"]))
                    {
                        double modelweighs = keyValuePairs[key] + (double)dr["em_weight"];
                        keyValuePairs.Remove(key);
                        keyValuePairs.Add(key, modelweighs);
                    }
                }
                keyValuePairs.Add((string)dr["pa_modle"], (double)dr["em_weight"]);
            }
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
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();

            Package package = new Package();
            package.pa_barrelId = barrelId;
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            maker.AddAndCondition(new IntEqual("pa_id", package.pa_barrelId.Value));
            DataTable dataTable = package.Select(maker.MakeSelectSql());
            foreach (DataRow dr in dataTable.Rows)
            {
                Dictionary<string, double>.KeyCollection keyCol = keyValuePairs.Keys;
                foreach (string key in keyCol)
                {
                    if (key.Equals((string)dr["pa_modle"]))
                    {
                        double modelweighs = keyValuePairs[key] + (double)dr["em_weight"];
                        keyValuePairs.Remove(key);
                        keyValuePairs.Add(key, modelweighs);
                    }
                }
                keyValuePairs.Add((string)dr["pa_modle"], (double)dr["em_weight"]);
            }
            return keyValuePairs;
        }
    }
}
