using Crc16;
using DBCLibrary;
using My_app1.PMSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_app1
{
    public partial class frmSetIP : Form
    {
        public Socket newclient;
        public bool Connectedtest;
        public delegate void MyInvoke(string str);
        frmMain sock;
        public frmSetIP(frmMain sock)
        {
            InitializeComponent();
            this.sock = sock;
        }
        public void Connect()
        {
            //serverIP.Text = "192.168.1.200";
            //serverPort.Text = "4196";
            byte[] data = new byte[1024];
            newclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);    //构造socket对象
            string ipadd = serverIP.Text.Trim();        //输入IP地址
            int port = Convert.ToInt32(serverPort.Text.Trim());     //输入端口号
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ipadd), port);       //表示网络端点       
            try
            {
                newclient.Connect(ie);   //与服务器连接 
                Connectedtest = true;
            }
            catch (SocketException e)
            {
                MessageBox.Show("连接服务器失败  " + e.Message);
                return;
            }
        }
        public void DisConnect()        //断开连接
        {
            newclient.Shutdown(SocketShutdown.Both);
            newclient.Close();
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Connect();
            ConnectButton.Enabled = false;
            DisableConnectButton.Enabled = true;

            OperationQuery.Event_Record(sock.Limit, "网关连接成功");//事件录入（用户级别，自定义字符串操作）
            frmEquipmentState EquipmentState = new frmEquipmentState(this);
            //EquipmentState.WindowState = FormWindowState.Maximized;
            EquipmentState.Show();

            this.Hide();
        }
        private void DisableConnectButton_Click(object sender, EventArgs e)
        {
            DisConnect();
            ConnectButton.Enabled = true;
        }
        public bool SendData(string strData)                //发送数据
        {
            crc16 crc = new crc16();
            byte[] bytes = strToToHexByte(crc.modbuscrc(strData));
            //byte[] bytes = strToToHexByte(strData);
            try
            {
                newclient.Send(bytes);
                return true;
            }
            catch
            {
                if (newclient != null)
                {
                    newclient.Shutdown(SocketShutdown.Both);
                    newclient.Close();
                    if (Connectedtest)
                    {
                        return SendData(strData);
                    }
                }
            }
            return false;
        }
        private byte[] strToToHexByte(string hexString)                 //字符串转数组
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);
            return returnBytes;
        }
        public string ReceiveMsg()                             //接收数据
        {
            string strData = string.Empty;
            int nLength = 0;
            byte[] bytes = new byte[1024];
            newclient.ReceiveTimeout = 100;             //设置超时100
            if (null != newclient && newclient.Connected)
            {
                try
                {
                    nLength = newclient.Receive(bytes);
                }
                catch (SocketException)
                {

                }
                for (int i = 0; i < nLength; i++)
                {
                    strData += bytes[i].ToString("X2");     //十六进制
                }
            }
            return strData;
        }
    }
}

