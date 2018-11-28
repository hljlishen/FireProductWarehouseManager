using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FireProductManager.ServiceLogicPackage
{
    public class PackageGateway
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
            //if (!HasBarrel(barrelId)) throw new Exception("不存在该桶");
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

        //获取全部材料
        public static DataTable GetAllPackage()
        {
            Package package = new Package();
            SelectSqlMaker maker = new SelectSqlMaker("package");
            return Query(maker.MakeSelectSql());
        }

        //获取材料信息
        public static DataTable GetPackageInformation(int packageId)
        {

            Package package = new Package();
            package.pa_id = packageId;
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new IntEqual("pa_id", packageId));
            DataTable dataTable = package.Select(maker.MakeSelectSql());
            return dataTable;
        }

        //添加材料 
        public static void NewPackage(string name, string model, Double weigth, int barrelId, string isinWarehouse, DateTime purchaseTime ,int projectId)
        {
            Package package = new Package();
            package.pa_name = name;
            package.pa_model = model;
            package.pa_weight = weigth;
            package.pa_barrelId = barrelId;
            package.pa_isinWarehouse = IsinWarehouseDataTypeChangeInt(isinWarehouse);
            package.pa_purchaseTime = purchaseTime;
            package.pa_projectId = projectId;
            FormValidation(package);
            package.Insert();
        }

        //修改材料 
        public static void UpdatePackage(int id ,string name, string model, Double weigth, int barrelId, string isinWarehouse, DateTime purchaseTime, int projectId)
        {
            Package package = new Package();
            package.pa_id = id;
            package.pa_name = name;
            package.pa_model = model;
            package.pa_weight = weigth;
            package.pa_barrelId = barrelId;
            package.pa_isinWarehouse = IsinWarehouseDataTypeChangeInt(isinWarehouse);
            package.pa_purchaseTime = purchaseTime;
            package.pa_projectId = projectId;
            FormValidation(package);
            package.Update();
        }

        //删除材料 
        public static void DeletePackage(int packageId)
        {
            Package package = new Package();
            package.pa_id = packageId;
            package.Delete();
        }

        //表单验证
        private static void FormValidation(Package package)
        {
            
        }

        //在库状态转化为int
        private static int IsinWarehouseDataTypeChangeInt(string isinWarehouse)
        {
            int _isinWarehouse = -1;
            if (isinWarehouse.Equals("在库")) return 0;
            if (isinWarehouse.Equals("不在库")) return 1;
            return _isinWarehouse;
        }

        //在库状态转化为
        public static string IsinWarehouseDataTypeChangeString(int isinWarehouse)
        {
            string _isinWarehouse = "不在库";
            if (isinWarehouse == 0) return "在库";
            return _isinWarehouse;
        }

        //材料搜索
        public static DataTable GetQueryPackage(string name, string model, string barrelId, string isinWarehouse, string projectId)
        {
            int _barrelId = barrelId.Equals("") ? 0 : Convert.ToInt32(barrelId);
            int _isInWareHouse = isinWarehouse.Equals("全部") ? -1 : IsinWarehouseDataTypeChangeInt(isinWarehouse);
            int _projectId = projectId.Equals("") ? 0 : Convert.ToInt32(projectId);
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new StringLike("pa_name", name));
            maker.AddAndCondition(new StringLike("pa_model", model));
            if (_barrelId != 0) maker.AddAndCondition(new IntEqual("pa_barrelId", _barrelId));
            if(_isInWareHouse !=-1) maker.AddAndCondition(new IntEqual("pa_isinWarehouse", _isInWareHouse));
            if (_projectId != 0) maker.AddAndCondition(new IntEqual("pa_projectId", _projectId));
            return Query(maker.MakeSelectSql()); 
        }
    }
}
