﻿using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage
{
    class PackageGateway
    {
        public static List<Package> Query(string sql)
        {
            List<Package> list = new List<Package>();
            return list;
        }

        public static void SwitchDepartment(int packageId, int barrelId)
        {

        }

        public static List<Package> GetAllModels(int employeeId)
        {
            List<Package> list = new List<Package>();
            return list;
        }

        public static Dictionary<string,double> StatisticWeights()
        {
            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
            return keyValuePairs;
        }
    }
}
