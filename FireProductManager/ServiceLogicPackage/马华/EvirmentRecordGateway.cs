using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FireProductManager.ServiceLogicPackage
{
    class EvirmentRecordGateway
    {
        public delegate void NewEvirmentDataHandler(double temp, double hum);

        public event NewEvirmentDataHandler NewEvirmentData;

        private Timer updateDisplay;
        private int updateDisplayInterval;
        private Timer writeDatabase;
        private int writeDatabaseInterval;
        private IEvirmentDevice device;

        private void DataReceivedHandle(byte[] e)
        {

        }

        private void RecordEvirmentData()
        {

        }

        public static List<EvirmentRecord> Query(string sql)
        {
            List<EvirmentRecord> evirmentRecords = new List<EvirmentRecord>();
            return evirmentRecords;
        }
    }
}
