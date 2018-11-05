using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//信息提示窗

namespace cangku_01.view.AdminPage
{
    public partial class AutoCloseMassageBox : Form
    {
        public AutoCloseMassageBox()
        {
            InitializeComponent();
        }

        private void AutoCloseMassageBox_Load(object sender, EventArgs e)
        {

        }

        public void getMassage(string text)//显示的提示信息
        {
            la_massageshow.Text = text;
        }

        public void GetText(string caption)//显示的文本标题（左上角的窗体标题提示）
        {
            this.Text = caption;
        }
        public AutoCloseMassageBox m_MassageBox;
        //自动关闭弹出提示框
        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            //参数含义：text: 提示信息 、 caption：提示框窗体左上角标题文本，注意：当两个或多个提示框标题相同且同时出现时，会优先关闭浮在最上层提示框，但下层不会自动关闭，
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                //新建一个自动关闭弹出提示框对象   AutoCloseMassageBox为自动关闭提示框窗体名称
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,null, timeout, System.Threading.Timeout.Infinite);
                AutoCloseMassageBox m_MassageBox = new AutoCloseMassageBox();
                m_MassageBox.getMassage(text);//m_MassageBox 对象调用自身的getMassage函数获取外部传入需要提示的信息
                m_MassageBox.GetText(caption);//m_MassageBox 对象调用自身的GetText函数获取外部传入需要提示的文本标题
                m_MassageBox.ShowDialog();//调用ShowDialog()函数     showDialog()是一个对话框窗口界面```执行结果以新窗口界面出现```不允许进行后台运行```就是你想编辑什么的时候```非得先关闭showDialog()窗口界面才可以进行其他操作```
            }

            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }

            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow(null, _caption);
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }
    }
}

