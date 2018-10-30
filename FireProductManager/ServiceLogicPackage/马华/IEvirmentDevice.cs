using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireProductManager.ServiceLogicPackage
{
    public delegate void DataReceivedHandler(double temp,double hum);

    interface IEvirmentDevice
    {
        event DataReceivedHandler DataReceived;

        void Open();

        void Close();
    }

    class IEvirmentJoint : IEvirmentDevice
    {
        public event DataReceivedHandler DataReceived;

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
