using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FireProductManager.ServiceLogicPackage.Tests
{
    [TestClass()]
    public class RecordOperationGatewayTests
    {
        [TestMethod()]
        public void QueryTest()
        {
            string sql = "select * from inoutrecord where ior_id = 1";
            DataTable dt = RecordOperationGateway.Query(sql);
        }

        [TestMethod()]
        public void BorrowPackageTest()
        {
            int packageid = 1;
            int employeeid = 1;
            RecordOperationGateway.BorrowPackage(packageid,employeeid);
        }

        [TestMethod()]
        public void ReturnPackageTest()
        {
            int packageid = 1;
            int barrelid = 1;
            RecordOperationGateway.ReturnPackage(packageid, barrelid);
        }
    }
}