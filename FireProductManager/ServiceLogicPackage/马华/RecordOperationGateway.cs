using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage
{
    class RecordOperationGateway
    {

        public static DataTable Query(string sql)
        {
            InOutRecord inOutRecord = new InOutRecord();
            var query = inOutRecord.Select(sql);
            return query;
        }

        //借包
        public static void BorrowPackage(int packageid)
        {

        }

        //还包
        public static void ReturnPackage(int packageid,int barrelid)
        {

        }
    }
}
