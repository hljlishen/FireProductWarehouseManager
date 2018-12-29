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
                    if (!model.Equals((string)dr["pa_specifications"]))
                    {
                        list.Add((string)dr["pa_specifications"]);
                    }
                }
            }

            return list;
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
                string model = dr["pa_specifications"].ToString();
                if (allModel.Contains(model))
                    continue;
                allModel.Add(model);
            }

            return allModel;
        }


        //获取当前材料的类型与重量
        public static Dictionary<string, double> StatisticAllModelWeightsInWarehouse()
        {
            Package package = new Package();
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            DataTable dataTable = package.Select(maker.MakeSelectSql());
            Dictionary<string, double> keyValuePairs = GetModleOfWeight(dataTable);
            return keyValuePairs;
        }

        private static Dictionary<string, double> GetModleOfWeight(DataTable dataTable)
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            foreach (DataRow dr in dataTable.Rows)
            {
                string key = (string)dr["pa_type"];
                if (keyValuePairs.Keys.Contains(key))
                {
                    keyValuePairs[key] += (double)dr["pa_weight"];
                }
                else
                {
                    keyValuePairs.Add((string)dr["pa_type"], (double)dr["pa_weight"]);
                }
            }
            return keyValuePairs;
        }

        //获取材料入库重量
        public static Dictionary<string, double> StatisticAllModelBeginningWeightsInWarehouse()
        {
            Package package = new Package();
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            maker.AddAndCondition(new IntEqual("pa_isinWarehouse", 0));
            DataTable dataTable = package.Select(maker.MakeSelectSql());
            Dictionary<string, double> keyValuePairs = GetModleOfBeginningWeight(dataTable);
            return keyValuePairs;
        }

        private static Dictionary<string, double> GetModleOfBeginningWeight(DataTable dataTable)
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            foreach (DataRow dr in dataTable.Rows)
            {
                string key = (string)dr["pa_type"];
                if (keyValuePairs.Keys.Contains(key))
                {
                    keyValuePairs[key] += (double)dr["pa_beginningweight"];
                }
                else
                {
                    keyValuePairs.Add((string)dr["pa_type"], (double)dr["pa_beginningweight"]);
                }
            }
            return keyValuePairs;
        }

        //获取材料的用量
        public static Dictionary<string, double> GetPackageDosage()
        {
            Package package = new Package();
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            maker.AddAndCondition(new IntEqual("pa_isinWarehouse", 0));
            DataTable dataTable = package.Select(maker.MakeSelectSql());
            Dictionary<string, double> keyValuePairs = GetPackageDosageModleOfWeight(dataTable);
            return keyValuePairs;
        }

        private static Dictionary<string, double> GetPackageDosageModleOfWeight(DataTable dataTable)
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            foreach (DataRow dr in dataTable.Rows)
            {
                string key = (string)dr["pa_type"];
                if (keyValuePairs.Keys.Contains(key))
                {
                    keyValuePairs[key] += ((double)dr["pa_beginningweight"] - (double)dr["pa_weight"]);
                }
                else
                {
                    keyValuePairs.Add((string)dr["pa_type"], ((double)dr["pa_beginningweight"] - (double)dr["pa_weight"]));
                }
            }
            return keyValuePairs;
        }

        //获取出库材料
        public static Dictionary<string, double> GetPackageOutbound()
        {
            Package package = new Package();
            SelectSqlMaker maker = new SelectSqlMaker("Package");
            maker.AddAndCondition(new IntEqual("pa_isinWarehouse", 1));
            DataTable dataTable = package.Select(maker.MakeSelectSql());
            Dictionary<string, double> keyValuePairs = GetModleOfWeight(dataTable);
            return keyValuePairs;
        }

        //获取项目使用的材料的类型与重量
        public static Dictionary<string, double> GetProjectPackageDosage(uint projectid)
        {
            OutRecord outRecord = new OutRecord();
            SelectSqlMaker maker = new SelectSqlMaker("outrecord");
            maker.AddAndCondition(new IntEqual("or_projectId", (int)projectid));
            DataTable dataTable = outRecord.Select(maker.MakeSelectSql());
            Dictionary<string, double> keyValuePairs = ProjectPackageDosageModleOfWeight(dataTable);
            return keyValuePairs;
        }

        private static Dictionary<string, double> ProjectPackageDosageModleOfWeight(DataTable dataTable)
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            foreach (DataRow dr in dataTable.Rows)
            {
                DataTable dt = GetPackageInformation((int)dr["or_packageId"]);
                DataRow myDr = dt.Rows[0];
                if ((int)myDr["pa_isinwarehouse"] == 1) continue;
                string key = myDr["pa_type"].ToString();
                if (keyValuePairs.Keys.Contains(key))
                { 
                    keyValuePairs[key] += GetInRecordInformation((int)dr["or_id"]); ;
                }
                else
                {
                    keyValuePairs.Add((string)myDr["pa_type"], GetInRecordInformation((int)dr["or_id"]));
                }
            }
            return keyValuePairs;
        }

        //获取入库信息
        private static double GetInRecordInformation(int outrecordid)
        {
            InRecord inRecord = new InRecord();
            inRecord.ir_outid = (uint)outrecordid;
            SelectSqlMaker maker = new SelectSqlMaker("inrecord");
            maker.AddAndCondition(new IntEqual("ir_outid", outrecordid));
            DataTable dataTable = inRecord.Select(maker.MakeSelectSql());
            DataRow myDr = dataTable.Rows[0];
            double consumption = (double)myDr["ir_consumption"];
            return consumption;
        }

        //获取项目出库的材料的类型与重量
        public static Dictionary<string, double> GetProjectPackageOutRecord(uint projectid)
        {
            OutRecord outRecord = new OutRecord();
            SelectSqlMaker maker = new SelectSqlMaker("outrecord");
            maker.AddAndCondition(new IntEqual("or_projectId", (int)projectid));
            DataTable dataTable = outRecord.Select(maker.MakeSelectSql());
            Dictionary<string, double> keyValuePairs = ProjectPackageOutRecordModleOfWeight(dataTable);
            return keyValuePairs;
        }

        private static Dictionary<string, double> ProjectPackageOutRecordModleOfWeight(DataTable dataTable)
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            foreach (DataRow dr in dataTable.Rows)
            {
                DataTable dt = GetPackageInformation((int)dr["or_packageId"]);
                DataRow myDr = dt.Rows[0];
                if ((int)myDr["pa_isinwarehouse"] == 0) continue;
                string key = myDr["pa_type"].ToString();
                if (keyValuePairs.Keys.Contains(key))
                {
                    keyValuePairs[key] += (double)dr["or_outWeight"];
                }
                else
                {
                    keyValuePairs.Add((string)myDr["pa_type"], (double)dr["or_outWeight"]);
                }
            }
            return keyValuePairs;
        }

        internal static void ReturnPackage(int packageid, int barrelid , double weigth)
        {
            Package package = new Package();
            package.pa_id = packageid;
            package.pa_isinWarehouse = 0;
            package.pa_barrelId = barrelid;
            package.pa_weight = weigth;
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
        public static void NewPackage(string type, string specifications, double weigth, int barrelId, string isinWarehouse, string productionCompany, DateTime purchaseTime)
        {
            Package package = new Package();
            package.pa_type = type;
            package.pa_specifications = specifications;
            package.pa_weight = weigth;
            package.pa_barrelId = barrelId;
            package.pa_isinWarehouse = IsinWarehouseDataTypeChangeInt(isinWarehouse);
            package.pa_productionCompany = productionCompany;
            package.pa_purchaseTime = purchaseTime;
            package.pa_beginningweight = weigth;
            package.Insert();
        }

        //修改材料 
        public static void UpdatePackage(int id ,string type, string specifications, double weigth, int barrelId, string isinWarehouse,string productionCompany, DateTime purchaseTime)
        {
            Package package = new Package();
            package.pa_id = id;
            package.pa_type = type;
            package.pa_specifications = specifications;
            package.pa_weight = weigth;
            package.pa_barrelId = barrelId;
            package.pa_isinWarehouse = IsinWarehouseDataTypeChangeInt(isinWarehouse);
            package.pa_productionCompany = productionCompany;
            package.pa_purchaseTime = purchaseTime;
            package.Update();
        }

        //删除材料 
        public static void DeletePackage(int packageId)
        {
            Package package = new Package();
            package.pa_id = packageId;
            package.Delete();
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
        public static DataTable GetQueryPackage(string type, string specifications, string barrelId,string productioncompany, string isinWarehouse)
        {
            int _isInWareHouse = isinWarehouse.Equals("全部") ? -1 : IsinWarehouseDataTypeChangeInt(isinWarehouse);
            SelectSqlMaker maker = new SelectSqlMaker("package");
            maker.AddAndCondition(new StringLike("pa_type", type));
            maker.AddAndCondition(new StringLike("pa_specifications", specifications));
            maker.AddAndCondition(new IntEqual("pa_barrelId", barrelId));
            maker.AddAndCondition(new StringLike("pa_productioncompany", productioncompany));
            if (_isInWareHouse !=-1) maker.AddAndCondition(new IntEqual("pa_isinWarehouse", _isInWareHouse));
            return Query(maker.MakeSelectSql()); 
        }

        public DataTable GetPackagesInBarrel(string barrelId) => GetQueryPackage(null, null, barrelId, null, null);

        //获取最新插入的数据
        public static int GetLastPackage()
        {
            string sql = "select * from package pa_id order by pa_id desc";
            DataTable dataTable = Query(sql);
            DataRow myDr = dataTable.Rows[0];
            int packageid = (int)myDr["pa_id"];
            return packageid;
        }
    }
}
