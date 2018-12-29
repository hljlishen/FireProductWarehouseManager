using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FireProductManager.ServiceLogicPackage;
using System.Runtime.InteropServices;

namespace FireProductManager.GuiPackage
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public partial class WarehouseDataReport : Form
    {
        static List<string> liststring = new List<string>();
        static List<double> listdouble = new List<double>();

        static int ArrayLenght;

        string str = Directory.GetCurrentDirectory();

        public WarehouseDataReport()
        {
            InitializeComponent();

            //获取Winfrom的WebBrowser
            webBrowser1.ObjectForScripting = this;
            webBrowser2.ObjectForScripting = this;

            //初始化浏览器
            initWebBrowser();
        }

        private void initWebBrowser()
        {
            //防止 WebBrowser 控件打开拖放到其上的文件。
            webBrowser2.AllowWebBrowserDrop = false;

            //防止 WebBrowser 控件在用户右击它时显示其快捷菜单.
            webBrowser2.IsWebBrowserContextMenuEnabled = false;

            //以防止 WebBrowser 控件响应快捷键。
            webBrowser2.WebBrowserShortcutsEnabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string webname = "html/index.html";

            if (comboBox2.Text.Trim().Equals("入库材料"))
            {
                webname = "html/index.html";
                ChangeArray(PackageGateway.StatisticAllModelWeightsInWarehouse());

            } 

            if (comboBox2.Text.Trim().Equals("使用材料")) webname = "html/index6.html";
            if (comboBox2.Text.Trim().Equals("剩余材料")) webname = "html/index3.html";
            webBrowser2.Url = new Uri(str + "\\" + webname);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string webname = "html/index.html";

            if (comboBox1.Text.Trim().Equals("入库材料"))
            {
                webname = "html/index.html";
                webBrowser1.Navigate(str + "\\" + webname);
                
                ChangeArray(PackageGateway.StatisticAllModelWeightsInWarehouse());
            }

            if (comboBox1.Text.Trim().Equals("使用材料")) webname = "html/index6.html";
            if (comboBox1.Text.Trim().Equals("剩余材料")) webname = "html/index3.html";
            webBrowser1.Url = new Uri(str + "\\" + webname);
        }

        public static void ChangeArray(Dictionary<string, double> keyValuePairs)
        {
            int i = 0;
            foreach (var item in keyValuePairs)
            {
                liststring.Add(item.Key);
                listdouble.Add(item.Value);
                i++;
            }
            ArrayLenght = i-1;
        }

        public int GetArrayLenght()
        {
            return ArrayLenght;
        }

        public string GetDataString(int i)
        {
            return liststring[i];
        }

        public double GetDataDouble(int i)
        {
            return listdouble[i];
        }
    }
}
