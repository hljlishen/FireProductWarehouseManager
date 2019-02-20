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
    class SystemDictionaryGateway
    {
        //添加系统字典
        public static void NewSystemDictionary(string type, string text)
        {
            SystemDictionary systemDictionary = new SystemDictionary();
            systemDictionary.sy_type = type;
            systemDictionary.sy_text = text;
            systemDictionary.Insert();
        }

        //删除系统字典
        public static void DeleteSystemDictionary(int systemDictionaryId)
        {
            SystemDictionary systemDictionary = new SystemDictionary();
            systemDictionary.sy_id = systemDictionaryId;
            systemDictionary.Delete();
        }

        //获得一类型系统字典
        public static DataTable GetQueryDictionaryTypeText(string type)
        {
            SelectSqlMaker maker = new SelectSqlMaker("systemdictionary");
            maker.AddAndCondition(new StringEqual("sy_type", type));
            return Query(maker.MakeSelectSql());
        }

        //系统字典查询 
        private static DataTable Query(string sql)
        {
            DataTable dataTable = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return dataTable;
        }

        //获得一类型系统字典DataTable转List
        public static IList<string> DataTableChangeList(DataTable dt)
        {
            IList<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["sy_text"].ToString()); 
            }
            return list;
        }
    }
}
