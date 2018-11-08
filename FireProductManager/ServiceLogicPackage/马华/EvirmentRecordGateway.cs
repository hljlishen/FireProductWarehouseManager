using DbLink;
using FireProductManager.EntityPackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FireProductManager.ServiceLogicPackage
{
    public class EvirmentRecordGateway
    {
        public delegate void NewEvirmentDataHandler(double temp, double humi);

        public event NewEvirmentDataHandler NewEvirmentData;

        private Timer updateDisplay;//更新显示
        private int updateDisplayInterval; //更新显示的时间间隔 
        private Timer writeDatabase;//写数据库
        private int writeDatabaseInterval;//写数据库的时间间隔
        private IEvirmentDevice device;
        bool shouldRecord = true;

        //初始化函数??
        public EvirmentRecordGateway()
        {
            device.DataReceived += DataReceivedHandle;
            updateDisplayInterval = 1000;
            updateDisplay = new Timer();
            updateDisplay.Interval = updateDisplayInterval;
            updateDisplay.Tick += Timer_Tick;
            updateDisplay.Start();

            NewEvirmentData += RecordEvirmentData;
            writeDatabaseInterval = 300000;
            writeDatabase = new Timer();
            writeDatabase.Interval = writeDatabaseInterval;
            writeDatabase.Tick += Timer_Tick;
            writeDatabase.Start();

        }

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
            if (shouldRecord)
            {
                EvirmentRecord evirmentRecord = new EvirmentRecord();
                evirmentRecord.er_temperature = temperature;
                evirmentRecord.er_humidity = humidity;
                evirmentRecord.er_timeStmp = DateTime.Now;
                evirmentRecord.Insert();
            }
            shouldRecord = false;
        }

        public static DataTable Query(string sql)
        {
            var query = ActiveRecord.Select(sql, DbLinkManager.databaseType, DbLinkManager.connectString);
            return query;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            shouldRecord = true;
        }
    }
}
