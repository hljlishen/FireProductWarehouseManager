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
    public class EmployeeGatewayTests
    {
        [TestMethod()]
        public void QueryTest()
        {
            string sql = "select * from employee where id = 1";
            DataTable dt =  EmployeeGateway.Query(sql);
            Assert.Fail();
        }
    }
}