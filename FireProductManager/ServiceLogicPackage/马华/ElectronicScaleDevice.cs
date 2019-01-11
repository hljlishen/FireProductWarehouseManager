﻿using System;
using System.IO.Ports;

namespace FireProductManager.ServiceLogicPackage
{
    public delegate void WeightGettedHandler(double weigh);
    public interface ElectronicScaleDevice
    {
         event WeightGettedHandler WeightGetted;
    }

    public class Ahdr : ElectronicScaleDevice

    {
        public event WeightGettedHandler WeightGetted;
        private SerialPort serialPort;
        private const int baudRate = 9600;

        public Ahdr()
        {
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
            string weight = weightStr.Substring(3, gIndex - 4).Trim();

            return double.Parse(weight);
        }

        private bool IsConnection(string[] names)
        {
            int i = names.Length;
            return i>0;
        }
    }
}
