using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage.燕廷
{
    class WebGateData
    {
        static List<string> liststring;
        static List<double> listdouble;



        public static void ChangeArray(Dictionary<string, double> keyValuePairs)
        {
            foreach (var item in keyValuePairs)
            {
                liststring.Add(item.Key);
                listdouble.Add(item.Value);
            }
        }

        public static int ArrayLenght()
        {
            int i = liststring.Count;
            return i;
        }

        public static string GetDataString(int i)
        {
            return liststring[i];
        }

        public static double GetDataDouble(int i)
        {
            return listdouble[i];
        }
    }
}
