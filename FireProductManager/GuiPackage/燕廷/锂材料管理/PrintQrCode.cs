using FireProductManager.ServiceLogicPackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace FireProductManager.GuiPackage
{
    public partial class PrintQRCode : Form
    {
        private int _packageid;

        public PrintQRCode(int packageid)
        {
            InitializeComponent();
            _packageid = packageid;
            string msg = packageid.ToString();

            PictureBoxShow(GenByZXingNet(msg));

            InstrumentMessageDataTableShowTextBox();
            Print();
        }

        public void Print()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog(this) == DialogResult.OK) //到这里会出现选择打印项的窗口
            {
                printDocument.Print(); //到这里会出现给文件命名的窗口，点击确定后进行打印并完成打印
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (pb_qrcode.Image != null)
                {
                    e.Graphics.DrawImage(pb_qrcode.Image, new PointF(0, 0));
                    e.HasMorePages = false;
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void PictureBoxShow(Bitmap bmp)
        {
            pb_qrcode.Image?.Dispose();
            pb_qrcode.Image = bmp;
        }

        private Bitmap GenByZXingNet(string msg)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");//编码问题
            writer.Options.Hints.Add(EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.H);
            const int codeSizeInPixels = 250;   //设置图片长宽
            writer.Options.Height = writer.Options.Width = codeSizeInPixels;
            writer.Options.Margin = 5;//设置边框
            ZXing.Common.BitMatrix bm = writer.Encode(msg);
            Bitmap img = writer.Write(bm);
            AddTextToImg(img, msg);
            return img;
        }

        private void AddTextToImg(Bitmap bmp, string text)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            //字体大小
            float fontSize = 18.0f;
            Font font = new Font("微软雅黑", fontSize, FontStyle.Bold);
            Brush whiteBrush = new SolidBrush(Color.Black);
            //文本的长度
            SizeF size = graphics.MeasureString(text, font);
            float textWidth = text.Length * fontSize;
            //下面定义一个矩形区域，以后在这个矩形里画上白底黑字
            float rectX = 125 - size.Width / 2;
            float rectY = 210;
            float rectWidth = text.Length * (fontSize + 40);
            float rectHeight = fontSize + 40;
            //声明矩形域
            RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);
            graphics.DrawString(text, font, whiteBrush, textArea);
        }

        //仪器信息展示在页面组件中
        public void InstrumentMessageDataTableShowTextBox()
        {
            DataTable dataTable = PackageGateway.GetPackageInformation(_packageid);
            DataRow myDr = dataTable.Rows[0];
            la_name.Text = myDr["pa_name"].ToString();
            la_model.Text = myDr["pa_model"].ToString();
            la_purchaseTime.Text = myDr["pa_purchaseTime"].ToString();
        }

        private void PrintQRCode_Load(object sender, EventArgs e)
        {

        }
    }
}
