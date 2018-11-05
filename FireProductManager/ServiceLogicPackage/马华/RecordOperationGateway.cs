using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage
{
    class RecordOperationGateway
    {

        public static List<InOutRecord> Query(string sql)
        {
            List<InOutRecord> list = new List<InOutRecord>();
            return list;
        }

        public static void BorrowPackage(int packageId)
        {

        }

        public static void ReturnPackage(int packageId, int barrelId)
        {

        }
    }
}
