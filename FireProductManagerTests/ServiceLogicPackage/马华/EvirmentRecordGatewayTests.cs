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
    public class EvirmentRecordGatewayTests
    {
        [TestMethod()]
        public void QueryTest()
        {
            string sql = "select * from evirmentrecord where er_id = 1";
            DataTable dt = EvirmentRecordGateway.Query(sql);
        }

        [TestMethod()]
        public void EvirmentRecordGatewayTest()
        {
            EvirmentRecordGateway evirmentRecordGateway = new EvirmentRecordGateway();
        }
    }
}