using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FireProductManager.ServiceLogicPackage;
using FireProductManager.EntityPackage;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace FireProductManager.ServiceLogicPackage.Tests
{
    [TestClass()]
    public class AccountManagerTests
    {
        [TestMethod()]
        public void CanReadDatabaseTest()
        {
            AccountManager.CanReadDatabase();
        }

        [TestMethod()]
        public void CanWriteDatabaseTest()
        {
            AccountManager.CanWriteDatabase();
        }
    }
}

namespace FireProductManagerTests.ServiceLogicPackage
{
    [TestClass()]
    public class AccountManagerTests
    {
        //[TestMethod()]
        //public void LoginText()
        //{
        //    string accounts = "1";
        //    string password = "1";
        //    bool b = AccountManager.Login(accounts,password);
        //}
    }
}
