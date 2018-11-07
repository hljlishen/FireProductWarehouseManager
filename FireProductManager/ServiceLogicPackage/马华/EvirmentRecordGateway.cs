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
        public delegate void NewEvirmentDataHandler(double temp, double humi);

        public event NewEvirmentDataHandler NewEvirmentData;

        private Timer updateDisplay;
        private int updateDisplayInterval;
        private Timer writeDatabase;
        private int writeDatabaseInterval;
        private IEvirmentDevice device;

        //数据接收处理
        private void DataReceivedHandle(byte[] receiveData)
        {
            double temp = ((double)receiveData[12] * 256 + receiveData[13]) / 10;
            double humi = ((double)receiveData[14] * 256 + receiveData[15]) / 10;
            NewEvirmentData?.Invoke(temp, humi);
        }

        //记录数据
        private void RecordEvirmentData(double temperature, double humidity)
        {
            EvirmentRecord evirmentRecord = new EvirmentRecord();
            evirmentRecord.Er_Temperature = temperature;
            evirmentRecord.Er_Humidity = humidity;
            evirmentRecord.Er_TimeStmp = DateTime.Now;
            evirmentRecord.Insert();
        }

        public static List<EvirmentRecord> Query(string sql)
        {
            List<EvirmentRecord> evirmentRecords = new List<EvirmentRecord>();
            return evirmentRecords;
        }
    }
}
