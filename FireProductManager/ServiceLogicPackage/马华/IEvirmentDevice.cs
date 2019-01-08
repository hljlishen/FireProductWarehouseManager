using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace FireProductManager.ServiceLogicPackage
{
    public delegate void DataReceivedHandler(byte[] receiveData);

    interface IEvirmentDevice
    {
        event DataReceivedHandler DataReceived;

        void Open();

        void Close();
    }

    class Apem5900 : IEvirmentDevice
    {
        private Thread _readThread;
        private Socket _socket;
        public event DataReceivedHandler DataReceived;
        private static Apem5900 _instance = null;
        private static object locker = new object();

        public static IEvirmentDevice CreateInstance()
        {
            if(_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Apem5900();
                    }
                }
            }
            return _instance;
        }

        private Apem5900()
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 10050);
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.Bind(ip);
        }

        public void Open()
        {
            _readThread = new Thread(Read);
            _readThread.IsBackground = true;
            _readThread.Start();
        }

        public void Close() => _readThread?.Abort();

        public void Read()
        {
            while (true)
            {
                byte[] receiveData = new byte[100];
                _socket.Receive(receiveData);
                DataReceived?.Invoke(receiveData);
            }
        }
    }
}
