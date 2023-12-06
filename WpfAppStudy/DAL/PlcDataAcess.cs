using Org.BouncyCastle.Bcpg.OpenPgp;
using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Profinet;
using HslCommunication.Profinet.Melsec;

namespace WpfAppStudy.DAL
{
    public class PlcDataAcess
    {
        //生成Plc对象
        public MelsecA1ENet mel = new MelsecA1ENet();
        public PlcDataAcess(string ip,int port) { 
            mel.IpAddress = ip;
            mel.Port = port;
        }

        public bool isCOnnect() {
            OperateResult result = mel.ConnectServer();
            if (result.IsSuccess)
            {
                return true;
            }
            return false;
        }


    }
}
