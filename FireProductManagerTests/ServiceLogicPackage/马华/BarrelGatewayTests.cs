﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage.Tests
{
    [TestClass()]
    public class BarrelGatewayTests
    {
        [TestMethod()]
        public void RecordNewBarrelTest()
        {
            BarrelGateway.RecordNewBarrel();
        }

    }
}