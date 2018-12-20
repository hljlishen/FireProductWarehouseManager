using System;
using System.IO;
using System.Windows.Forms;

namespace FireProductManager.GuiPackage
{
    public partial class WarehouseDataReport : Form
    {
        string str = System.IO.Directory.GetCurrentDirectory();
        public WarehouseDataReport()
        {
            InitializeComponent();

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

        private void tb_allprojectdata_Click(object sender, EventArgs e)
        {

        }

        private void WarehouseDataReport_Load(object sender, EventArgs e)
        {
            
        }

       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string webname = "html/index.html";
            if (comboBox2.Text.Trim().Equals("入库材料")) webname = "html/index.html";
            if (comboBox2.Text.Trim().Equals("使用材料")) webname = "html/index6.html";
            if (comboBox2.Text.Trim().Equals("剩余材料")) webname = "html/index3.html";
            webBrowser2.Url = new Uri(str + "\\" + webname);
        }
    }
}
