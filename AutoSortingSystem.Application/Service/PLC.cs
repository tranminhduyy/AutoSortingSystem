using AutoSortingSystem.Application.ViewModel;
using S7.Net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace AutoSortingSystem.Application.Service
{
    public class PLC
    {
        Plc plc = new Plc(CpuType.S71500, Properties.Settings.Default.IPPLC, 0, 1);
        public bool PLC_Connected = false;

        protected PLC()
        {

        }

        private static PLC _instance;
        public static PLC Instance()
        {
            if (_instance == null)
            {
                _instance = new PLC();
                return _instance;
            }
            else
            {
                return _instance;
            }
        }

        public bool Open()
        {
            try
            {
                plc.Open();
            }
            catch
            {

            }
            PLC_Connected = (plc.IsConnected) ? true : false;
            return PLC_Connected;
        }

        public void Close()
        {
            try
            {
                PLC_Connected = false;
                plc.Close();
            }
            catch
            {

            }
        }

        public bool WriteRecipeData(byte[] data, bool _action)
        {
            try
            {
                if (PLC_Connected)
                {
                    plc.Write("DB1.DBW0.0", _action);  //Enable
                    plc.WriteBytes(DataType.DataBlock, 1, 2, data); //RecipaData
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool CheckPlcConnection()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send(Properties.Settings.Default.IPPLC, 1000);
                    if (reply.Status == IPStatus.Success)
                    {
                        if (PLC_Connected == false)
                        {
                            Open();
                        }
                        return true;
                    }
                    else
                    {
                        PLC_Connected = false;
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool[] CheckHasPackage()
        {
            try
            {
                if (PLC_Connected)
                {
                    var isCheckArr = new bool[6];
                    byte data = (byte)plc.Read(DataType.DataBlock, 2, 0, VarType.Byte, 1);
                    
                    if (data != 0)
                    {
                        byte b = 0x00000001;
                        for (int i = 0; i <= 5; i++)
                        {
                            isCheckArr[i] = ((data & b) != 0) ? true : false;
                            plc.WriteBit(DataType.DataBlock, 2, 0, i, false);
                            b = (byte)(b << 1);
                        }
                        return isCheckArr;
                    }
                    return null;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public int[] ReadJobCntFromPLC()
        {
            var jobCnt = new int[6];
            jobCnt = (int[])plc.Read(DataType.DataBlock, 5, 0, VarType.DWord, 6);
            return jobCnt;
        }

        public void ResetJobCntFromPLC()
        {
            int index = 0;
            byte[] resJobcCount = new byte[24];
            foreach (byte b in resJobcCount)
            {
                resJobcCount[index] = 0;
                index++;
            }
            plc.WriteBytes(DataType.DataBlock, 5, 0, resJobcCount);
        }
    }
}
