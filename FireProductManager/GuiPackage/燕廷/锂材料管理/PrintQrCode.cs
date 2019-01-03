using FireProductManager.ServiceLogicPackage;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;

namespace FireProductManager.GuiPackage
{
    public partial class PrintQRCode : Form
    {
        private int _packageid;
        private int _labelwide = 146;
        private int _labelhigh = 111;
        private int _codeSizeInPixels;

        public PrintQRCode(int packageid )
        {
            InitializeComponent();
            _packageid = packageid;
            string msg = PackageMessageDataTableShowTextBox();

            Bitmap bitmap = GenByZXingNet(msg);
            bitmap = NewLabelSize(bitmap);
            AddTextToImg(bitmap, msg);
            PictureBoxShow(bitmap);

            Print();
        }

        public void Print()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("123", 150, 110);
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

        private Bitmap NewLabelSize(Bitmap bm)
        {
            Bitmap bitmap = new Bitmap(_labelwide, _labelhigh);
            Graphics graphics = Graphics.FromImage(bitmap);

            float QrCode_X = _labelwide / 2 - (_codeSizeInPixels / 2);
            float QrCode_y = _labelhigh / 100 * 5;
            graphics.DrawImage(bm, new PointF(QrCode_X, QrCode_y));

            return bitmap;
        }

        private Bitmap GenByZXingNet(string msg)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");//编码问题
            writer.Options.Hints.Add(EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.H);
            int codeSizeInPixels = _labelhigh / 100 * 80;   //设置图片长宽
            _codeSizeInPixels = codeSizeInPixels;
            writer.Options.Height = writer.Options.Width = codeSizeInPixels;
            writer.Options.Margin = 0;//设置边框
            ZXing.Common.BitMatrix bm = writer.Encode(msg);
            Bitmap img = writer.Write(bm);
            return img;
        }

        private void AddTextToImg(Bitmap bmp, string text)
        {
            Graphics graphics = Graphics.FromImage(bmp);
            //字体大小
            float fontSize = 10.0f;
            Font font = new Font("宋体", fontSize, FontStyle.Regular);
            Brush whiteBrush = new SolidBrush(Color.Black);
            //文本的长度
            SizeF size = graphics.MeasureString(text, font);
            float textWidth = text.Length * fontSize;
            //下面定义一个矩形区域，以后在这个矩形里画上白底黑字
            float rectX = _labelwide / 2 - size.Width / 2;
            float rectY = _labelhigh / 100 * 85;
            float rectWidth = text.Length * (fontSize + 40);
            float rectHeight = fontSize + 40;
            //声明矩形域
            RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);
            graphics.DrawString(text, font, whiteBrush, textArea);
        }

        //材料信息展示在页面组件中
        public string PackageMessageDataTableShowTextBox()
        {
            DataTable dataTable = PackageGateway.GetPackageInformation(_packageid);
            DataRow myDr = dataTable.Rows[0];
            la_name.Text = myDr["pa_type"].ToString();
            la_model.Text = myDr["pa_specifications"].ToString();
            la_purchaseTime.Text = myDr["pa_purchaseTime"].ToString();
            string tagname = myDr["pa_type"].ToString() + "-" + myDr["pa_specifications"].ToString() + "-" + _packageid;
            return tagname;
        }
    }
}
