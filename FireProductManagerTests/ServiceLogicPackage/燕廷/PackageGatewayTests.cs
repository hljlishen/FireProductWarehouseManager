using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage.Tests
{
    [TestClass()]
    public class PackageGatewayTests
    {
        [TestMethod()]
        public void NewPackageTest()
        {
            PackageGateway.NewPackage("licaoliao","002",12,2,2,DateTime.Now,1);
        }

        [TestMethod()]
        public void PutPackageIntoBarrelTest()
        {
            PackageGateway.PutPackageIntoBarrel(1,2);
            
        }
    }
}