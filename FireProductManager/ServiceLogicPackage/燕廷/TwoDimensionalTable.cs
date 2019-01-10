using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    public class ChartType
    {
        public static ChartType pie = new ChartType();
        public static ChartType bar = new ChartType();
        public static ChartType line = new ChartType();

        private ChartType() { }
    }
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class TwoDimensionalTable
    {
        List<string> list_X = new List<string>();
        List<double> list_Y = new List<double>();
        string str = Directory.GetCurrentDirectory();

        public void GetType(ChartType type)
        {
            if (type == ChartType.bar)
            {

            }
        }

        public TwoDimensionalTable(WebBrowser webBrowser,string type, List<string> List_X, List<double> List_Y)
        {

            GetType(ChartType.bar);
            list_X = List_X;
            list_Y = List_Y;
            webBrowser.ObjectForScripting = this;
            string _webname = "html\\"+ type + ".html";
            webBrowser.Navigate(str + "\\" + _webname);
            webBrowser.Url = new Uri(str + "\\" + _webname);
        }

        public int GetArrayLenght()
        {
            return list_X.Count-1;
        }

        public string GetDataString(int i)
        {
            return list_X[i];
        }

        public double GetDataDouble(int i)
        {
            return list_Y[i];
        }

    }
}
