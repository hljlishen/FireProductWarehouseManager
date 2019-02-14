using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    public delegate void WeightGettedHandler(double weigh);
    public interface ElectronicScaleDevice
    {
         event WeightGettedHandler WeightGetted;

        void Open();
    }

    public class Ahdr : ElectronicScaleDevice

    {
        public event WeightGettedHandler WeightGetted;
        private SerialPort serialPort;
        private const int baudRate = 9600;
        private static Ahdr _instance = null;
        private static object locker = new object();
        public bool IsOpen { get; private set; } = false;

        public static ElectronicScaleDevice CreateInstance()
        {
            if (_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Ahdr();
                    }
                }
            }
            return _instance;
        }

        public void Open()
        {
            if (IsOpen) return;
            IsOpen = true;
            string[] names = SerialPort.GetPortNames();
            if (!IsConnection(names))
            {
                throw new Exception("未连接电子秤设备");
            }
            for (int i = 1; i < names.Length; i++)
            {
                string portName = names[i];

                serialPort = new SerialPort(portName, baudRate) { DataBits = 8, Parity = Parity.None, StopBits = StopBits.One };
                serialPort.ReceivedBytesThreshold = 1;
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                return;
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string weightStr = serialPort.ReadExisting();

            WeightGetted?.Invoke(GetWeight(weightStr));
        }

        private double GetWeight(string weightStr)
        {
            int gIndex = weightStr.IndexOf('g');
            string weight = weightStr.Substring(2, gIndex - 4).Trim();

            return double.Parse(weight);
        }

        private bool IsConnection(string[] names)
        {
            int i = names.Length;
            return i>1;
        }
    }
}
