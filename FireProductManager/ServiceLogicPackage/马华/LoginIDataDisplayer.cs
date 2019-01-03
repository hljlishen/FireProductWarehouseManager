using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    interface LoginIDataDisplayer
    {
        void FingerprintLogin(Fingerprint fingerprint);
    }

    class ConnectFingerprint
    {
        private static ConnectFingerprint connectFingerprint = new ConnectFingerprint();
        Fingerprint fingerprint = new Fingerprint();

        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private bool bIsConnected1 = false;//连接状态
        private int iMachineNumber = 1;//设备连接的序列号
        private string ipAddress = "192.168.1.201";
        List<LoginIDataDisplayer> displayers;

        private ConnectFingerprint()
        {
            displayers = new List<LoginIDataDisplayer>();
        }

        public void AddDisplayer(LoginIDataDisplayer displayer)
        {
            if (displayers.Contains(displayer)) return;

            displayers.Add(displayer);
        }

        public static ConnectFingerprint GetInstance() => connectFingerprint;

        //TCP\IP连接
        public void GetIPConnect()
        {
            bIsConnected1 = axCZKEM1.Connect_Net(ipAddress, 4370);//连接属性IP、端口号
            if (bIsConnected1 == true)
            {
                iMachineNumber = 1;
                axCZKEM1.RegEvent(iMachineNumber, 65535);
                if (axCZKEM1.RegEvent(iMachineNumber, 65535))//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                {
                    axCZKEM1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                }
            }
            else
            {
                MessageBox.Show("无法连接到进库指纹设备", "错误");
            }
        }

        #region RealTime Events

        //获取信息
        private void axCZKEM1_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode)
        {
            fingerprint.fi_accountNumber = sEnrollNumber;
            fingerprint.fi_ipAddress = ipAddress;
            fingerprint.fi_direction = "进库";
            string passtime = iYear.ToString() + "-" + iMonth.ToString() + "-" + iDay.ToString() + " " + iHour.ToString() + ":" + iMinute.ToString() + ":" + iSecond.ToString();
            fingerprint.fi_passtime = Convert.ToDateTime(passtime);
            fingerprint.Insert();
            foreach (var From1 in displayers)
                From1.FingerprintLogin(fingerprint);
        }
        #endregion

        //关闭连接
        public void CloseConnect()
        {
            axCZKEM1.Disconnect();
            bIsConnected1 = false;
        }
    }
}
