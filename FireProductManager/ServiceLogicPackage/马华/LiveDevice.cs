using libzkfpcsharp;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    public delegate void FingerprintDataHandler(Bitmap bmp,string s);
    public interface LiveDevice
    {
        event FingerprintDataHandler FingerprintData;
        void Open();
    }

    class Live : LiveDevice
    {
        IntPtr mDevHandle = IntPtr.Zero;
        IntPtr mDBHandle = IntPtr.Zero;
        static IntPtr FormHandle = IntPtr.Zero;
        bool bIsTimeToDie = false;
        byte[] FPBuffer;
        const int REGISTER_FINGER_COUNT = 3;

        private byte[][] RegTmps = new byte[3][];
        private byte[] RegTmp = new byte[2048];
        private byte[] CapTmp = new byte[2048];
        int cbCapTmp = 2048;

        private bool isInitialized = false;
        private int mfpWidth = 0;
        private int mfpHeight = 0;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;

        public event FingerprintDataHandler FingerprintData;
        private static Live _instance = null;
        private static object locker = new object();

        public static LiveDevice CreateInstance(IntPtr handel)
        {
            FormHandle = handel;
            if (_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Live();
                    }
                }
            }
            return _instance;
        }

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        public void Open()
        {
            int ret1 = zkfperrdef.ZKFP_ERR_OK;
            int index = 0;
            if (!isInitialized)
            {
                if ((ret1 = zkfp2.Init()) != zkfperrdef.ZKFP_ERR_OK)
                {
                    return;
                    //throw new Exception("未连接指纹采集器");
                }

                int ret = zkfp.ZKFP_ERR_OK;
                if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(index)))
                    return;
                if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
                {
                    zkfp2.CloseDevice(mDevHandle);
                    mDevHandle = IntPtr.Zero;
                    return;
                }
                for (int i = 0; i < 3; i++)
                {
                    RegTmps[i] = new byte[2048];
                }
                byte[] paramValue = new byte[8];
                int size = 4;
                zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

                size = 4;
                zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

                FPBuffer = new byte[mfpWidth * mfpHeight];
                Thread captureThread = new Thread(new ThreadStart(DoCapture));
                captureThread.IsBackground = true;
                captureThread.Start();
                bIsTimeToDie = false;
            }
        }

        private void DoCapture()
        { 
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    string s = Convert.ToBase64String(CapTmp);
                    MemoryStream ms = new MemoryStream();
                    BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
                    Bitmap bmp = new Bitmap(ms);
                    FingerprintData?.Invoke(bmp,s);
                } 
                Thread.Sleep(200);
            }
        }
    }
}
