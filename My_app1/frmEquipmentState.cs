
using DBCLibrary;
using My_app1.PMSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_app1
{
    public partial class frmEquipmentState : Form
    {
        frmSetIP SetIP;
        public frmEquipmentState(frmSetIP SetIP)
        {
            InitializeComponent();
            this.SetIP = SetIP;
            lv.FullRowSelect = true;
        }

        bool flognull = true;
        bool devtimerflog = false;
        bool detecflog = true;
        int n = -1;
        int m = -1;
        string receivemsg;
        string receivemsg1;
        public string device;
        public string treeviewbox;
        public string deviceaddress = "";
        public string deviceaddress1 = "";
        public string[] dr = { "", "", "", "", "" };
        public string[] olddr = { "", "", "", "", "" };
        public string Eqpm;
        public string locat = "未知";

        public string test1 = "";
        public string test2 = "";
        public string test3 = "";

        public int tvi = 0;

        public int[] Nod = new int[1000];
        public int nd = 0;

        public int[] faultflag = new int[1000];
        public int[] warnflag = new int[1000];
        public int[] smoke1flag = new int[1000];
        public int[] smoke2flag = new int[1000];
        public int[] fire1flag = new int[1000];
        public int[] fire2flag = new int[1000];
        private void AddressDetectionTime_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel16.Text = "    正在搜索网络中的设备，请稍后......";
            toolStripStatusLabel1.Text = DateTime.Now.ToLocalTime().ToString();
            if (devicesearch.SelectedNode.Name == "rootview")       //选中根目录时出现的界面
            {
                groupBox3.Visible = false;
            }
            else
            {
                groupBox3.Visible = true;
            }

            if (flognull == true)
            {
                n++;
                if (n > 50)
                {
                    AddressDetectionTime.Enabled = false;       //设备搜索完成后关闭定时器
                    this.devicesearch.ExpandAll();              //展开树视图控件所有节点
                    toolStripStatusLabel16.Text = "    搜索完成！";
                    Thread t = new Thread(Detection);     //创建线程
                    t.Start();                          //执行线程
                }
            }
            string str = n.ToString("X2");      //十进制转十六进制
            if (str.Length < 2)
            {
                str = "0" + str;
            }
            string data1 = str + "03000E0001";
            if (SetIP.newclient != null)
            {
                SetIP.SendData(data1);
            }

            receivemsg = SetIP.ReceiveMsg();        //接收数据
            if (receivemsg != "")
            {
                string tv = receivemsg.Substring(0, 2);      //截取指定位置的字符串
                int tvint = Convert.ToInt32(tv, 16);

                string tvin = Convert.ToString(tvint, 10);
                string tvi = "CCD480DP_" + tvin;
                devicesearch.Nodes[0].Nodes.Add(tvi);        //添加树视图控件子节点

                Nod[tvint] = nd++;

                flognull = true;
            }
        }
        private void devicesearch_AfterSelect(object sender, TreeViewEventArgs e)   //treeview树结构按钮事件
        {
            try
            {
                treeviewbox = devicesearch.SelectedNode.Text;
                int leng = treeviewbox.Length;
                if (leng == 10)
                {
                    deviceaddress = treeviewbox.Substring(9, 1);     //获取到指定地址值 （10以内）
                }
                if (leng == 11)
                {
                    deviceaddress = treeviewbox.Substring(9, 2);     //获取到指定地址值 （10~99）
                }
                int a = Convert.ToInt32(deviceaddress, 10);     //十进制字符串转换十进制整型
                deviceaddress1 = Convert.ToString(a, 16);       //十进制整型转换十六进制字符串
                Eqpm = "CCD480DP_" + deviceaddress;        //添加到DataGridView中的设备

                devicetimer.Enabled = true;                 //开启定时器

                if (devicesearch.SelectedNode.Name == "rootview")       //选中根目录时出现的界面
                {
                    groupBox3.Visible = false;
                }
                else
                {
                    groupBox3.Visible = true;
                }
            }
            catch(Exception)
            { }

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string rxmsg = "";       //接收到的数据
        string rxmsg2 = "";
        string SerialNumber = "";
        int i = 1, j = 0;

        string substr = "";
        int tex = 0;
        string SmokeValue = "";
        string SmokeValueold = "";

        string Fault = "";
        string Faultold = "";

        string AlarmLevel = "";
        string AlarmLevelold = "";

        int fault = 0;
        int warn = 0;
        int smoke1 = 0;
        int smoke2 = 0;
        int fire1 = 0;
        int fire2 = 0;

        string devicea = "";
        private void devicetimer_Tick(object sender, EventArgs e)       //定时刷新数据
        {
            try
            {
                toolStripStatusLabel1.Text = DateTime.Now.ToLocalTime().ToString();
                if (devtimerflog == true)
                {
                    detecflog = false;

                    groupBox1.Text = "设备 " + Eqpm + " 状态";      //组名
                    if (deviceaddress1.Length < 2)
                    {
                        deviceaddress1 = "0" + deviceaddress1;
                    }
                    devicea = deviceaddress1 + "04000E0003";
                    if (SetIP.newclient != null)
                    {
                        SetIP.SendData(devicea);
                    }
                    rxmsg = SetIP.ReceiveMsg();        //接收数据
                    if (rxmsg.Length == 22)
                    {
                        substr = rxmsg.Substring(6, 4);      //截取字符串
                        tex = Convert.ToInt32(substr, 16);      //十六进制字符串转十进制整型
                        SmokeValue = Convert.ToString(tex, 10);  //十进制整型转换成十进制字符串
                    }
                    else
                    {
                        SmokeValue = SmokeValueold;
                    }
                    SmokeContent.Text = SmokeValue;     //显示当前选中的设备烟雾实时含量
                    SmokeValueold = SmokeValue;

                    if (rxmsg.Length == 22)
                    {
                        Fault = Convert.ToString(Convert.ToInt32(rxmsg.Substring(10, 4), 16), 10);      //故障状态
                                                                                                        //AlarmRecording.alarm_recording("故障", "设备 " + Eqpm + "故障");
                    }
                    else
                    {
                        Fault = Faultold;
                    }
                    Faultold = Fault;

                    if (Fault == "0")
                    {
                        FaultState.Text = "正常";
                        FaultState.ForeColor = Color.Green;
                    }
                    else
                    {
                        FaultState.Text = "设备故障";
                        FaultState.ForeColor = Color.Red;

                        SerialNumber = Convert.ToString(i, 10);
                        dr[0] = SerialNumber;   //序号
                        dr[1] = Eqpm;           //设备
                        dr[2] = "设备故障";   //状态
                        dr[3] = locat;             //位置
                        dr[4] = DateTime.Now.ToLocalTime().ToString();    //时间（系统）
                        if ((dr[1] != olddr[1]) || (dr[2] != olddr[2]) || (dr[3] != olddr[3]))      //如果新的告警与上一次告警不同则记录
                        {
                            i++;
                            ListViewItem tempItem = new ListViewItem(dr[0].ToString()); //添加dr[0].ToString使第一列显示正常
                                                                                        //tempItem.SubItems.Add(dr[0].ToString());
                            tempItem.SubItems.Add(dr[1].ToString());
                            tempItem.SubItems.Add(dr[2].ToString());
                            tempItem.SubItems.Add(dr[3].ToString());
                            tempItem.SubItems.Add(dr[4].ToString());
                            lv.Items.Add(tempItem);
                            AlarmQuery.alarm_recording("故障", "设备 " + Eqpm + "故障"); 
                            //AlarmRecording.alarm_recording("type test", "alarm test");
                        }
                        for (j = 0; j < 5; j++)
                        {
                            olddr[j] = dr[j];
                        }
                    }

                    if (rxmsg.Length == 22)
                    {
                        AlarmLevel = Convert.ToString(Convert.ToInt32(rxmsg.Substring(14, 4), 16), 10);  //报警级别
                    }
                    else
                    {
                        AlarmLevel = AlarmLevelold;
                    }
                    AlarmLevelold = AlarmLevel;

                    switch (AlarmLevel)
                    {
                        case "1":
                            AlarmLevellabel.Text = "预警";
                            AlarmLevellabel.ForeColor = Color.Red;
                            toolStripStatusLabel4.BackColor = Color.Red;
                            toolStripStatusLabel5.BackColor = Color.Red;

                            SerialNumber = Convert.ToString(i, 10);
                            dr[0] = SerialNumber;   //序号
                            dr[1] = Eqpm;           //设备
                            dr[2] = "预警";   //状态
                            dr[3] = locat;             //位置
                            dr[4] = DateTime.Now.ToLocalTime().ToString();    //时间（系统）
                            if ((dr[1] != olddr[1]) || (dr[2] != olddr[2]) || (dr[3] != olddr[3]))      //如果新的告警与上一次告警不同则记录
                            {
                                i++;
                                ListViewItem tempItem = new ListViewItem(dr[0].ToString()); //添加dr[0].ToString使第一列显示正常
                                                                                            //tempItem.SubItems.Add(dr[0].ToString());
                                tempItem.SubItems.Add(dr[1].ToString());
                                tempItem.SubItems.Add(dr[2].ToString());
                                tempItem.SubItems.Add(dr[3].ToString());
                                tempItem.SubItems.Add(dr[4].ToString());
                                lv.Items.Add(tempItem);
                                AlarmQuery.alarm_recording("故障", "设备 " + Eqpm + "预警");
                                //AlarmRecording.alarm_recording("type test", "alarm test");
                            }
                            for (j = 0; j < 5; j++)
                            {
                                olddr[j] = dr[j];
                            }
                            break;
                        case "2":
                            AlarmLevellabel.Text = "烟雾1";
                            AlarmLevellabel.ForeColor = Color.Red;
                            toolStripStatusLabel6.BackColor = Color.Red;
                            toolStripStatusLabel7.BackColor = Color.Red;

                            SerialNumber = Convert.ToString(i, 10);
                            dr[0] = SerialNumber;   //序号
                            dr[1] = Eqpm;           //设备
                            dr[2] = "烟雾1";   //状态
                            dr[3] = locat;             //位置
                            dr[4] = DateTime.Now.ToLocalTime().ToString();    //时间（系统）
                            if ((dr[1] != olddr[1]) || (dr[2] != olddr[2]) || (dr[3] != olddr[3]))      //如果新的告警与上一次告警不同则记录
                            {
                                i++;
                                ListViewItem tempItem = new ListViewItem(dr[0].ToString()); //添加dr[0].ToString使第一列显示正常
                                                                                            //tempItem.SubItems.Add(dr[0].ToString());
                                tempItem.SubItems.Add(dr[1].ToString());
                                tempItem.SubItems.Add(dr[2].ToString());
                                tempItem.SubItems.Add(dr[3].ToString());
                                tempItem.SubItems.Add(dr[4].ToString());
                                lv.Items.Add(tempItem);
                                AlarmQuery.alarm_recording("故障", "设备 " + Eqpm + "烟雾1");
                                //AlarmRecording.alarm_recording("type test", "alarm test");
                            }
                            for (j = 0; j < 5; j++)
                            {
                                olddr[j] = dr[j];
                            }
                            break;
                        case "3":
                            AlarmLevellabel.Text = "烟雾2";
                            AlarmLevellabel.ForeColor = Color.Red;
                            toolStripStatusLabel8.BackColor = Color.Red;
                            toolStripStatusLabel9.BackColor = Color.Red;
                            SerialNumber = Convert.ToString(i, 10);
                            dr[0] = SerialNumber;   //序号
                            dr[1] = Eqpm;           //设备
                            dr[2] = "烟雾2";   //状态
                            dr[3] = locat;             //位置
                            dr[4] = DateTime.Now.ToLocalTime().ToString();    //时间（系统）
                            if ((dr[1] != olddr[1]) || (dr[2] != olddr[2]) || (dr[3] != olddr[3]))      //如果新的告警与上一次告警不同则记录
                            {
                                i++;
                                ListViewItem tempItem = new ListViewItem(dr[0].ToString()); //添加dr[0].ToString使第一列显示正常
                                                                                            //tempItem.SubItems.Add(dr[0].ToString());
                                tempItem.SubItems.Add(dr[1].ToString());
                                tempItem.SubItems.Add(dr[2].ToString());
                                tempItem.SubItems.Add(dr[3].ToString());
                                tempItem.SubItems.Add(dr[4].ToString());
                                lv.Items.Add(tempItem);
                                AlarmQuery.alarm_recording("故障", "设备 " + Eqpm + "烟雾2");
                                //AlarmRecording.alarm_recording("type test", "alarm test");
                            }
                            for (j = 0; j < 5; j++)
                            {
                                olddr[j] = dr[j];
                            }
                            break;
                        case "4":
                            AlarmLevellabel.Text = "火警1";
                            AlarmLevellabel.ForeColor = Color.Red;
                            toolStripStatusLabel10.BackColor = Color.Red;
                            toolStripStatusLabel11.BackColor = Color.Red;

                            SerialNumber = Convert.ToString(i, 10);
                            dr[0] = SerialNumber;   //序号
                            dr[1] = Eqpm;           //设备
                            dr[2] = "火警1";   //状态
                            dr[3] = locat;             //位置
                            dr[4] = DateTime.Now.ToLocalTime().ToString();    //时间（系统）
                            if ((dr[1] != olddr[1]) || (dr[2] != olddr[2]) || (dr[3] != olddr[3]))      //如果新的告警与上一次告警不同则记录
                            {
                                i++;
                                ListViewItem tempItem = new ListViewItem(dr[0].ToString()); //添加dr[0].ToString使第一列显示正常
                                                                                            //tempItem.SubItems.Add(dr[0].ToString());
                                tempItem.SubItems.Add(dr[1].ToString());
                                tempItem.SubItems.Add(dr[2].ToString());
                                tempItem.SubItems.Add(dr[3].ToString());
                                tempItem.SubItems.Add(dr[4].ToString());
                                lv.Items.Add(tempItem);
                                AlarmQuery.alarm_recording("故障", "设备 " + Eqpm + "火警1");
                                //AlarmRecording.alarm_recording("type test", "alarm test");
                            }
                            for (j = 0; j < 5; j++)
                            {
                                olddr[j] = dr[j];
                            }
                            break;
                        case "5":
                            AlarmLevellabel.Text = "火警2";
                            AlarmLevellabel.ForeColor = Color.Red;
                            toolStripStatusLabel12.BackColor = Color.Red;
                            toolStripStatusLabel13.BackColor = Color.Red;

                            SerialNumber = Convert.ToString(i, 10);
                            dr[0] = SerialNumber;   //序号
                            dr[1] = Eqpm;           //设备
                            dr[2] = "火警2";   //状态
                            dr[3] = locat;             //位置
                            dr[4] = DateTime.Now.ToLocalTime().ToString();    //时间（系统）
                            if ((dr[1] != olddr[1]) || (dr[2] != olddr[2]) || (dr[3] != olddr[3]))      //如果新的告警与上一次告警不同则记录
                            {
                                i++;
                                ListViewItem tempItem = new ListViewItem(dr[0].ToString()); //添加dr[0].ToString使第一列显示正常
                                                                                            //tempItem.SubItems.Add(dr[0].ToString());
                                tempItem.SubItems.Add(dr[1].ToString());
                                tempItem.SubItems.Add(dr[2].ToString());
                                tempItem.SubItems.Add(dr[3].ToString());
                                tempItem.SubItems.Add(dr[4].ToString());
                                lv.Items.Add(tempItem);
                                AlarmQuery.alarm_recording("故障", "设备 " + Eqpm + "火警2");
                                //AlarmRecording.alarm_recording("type test", "alarm test");
                            }
                            for (j = 0; j < 5; j++)
                            {
                                olddr[j] = dr[j];
                            }
                            break;
                        default:
                            AlarmLevellabel.Text = "无";
                            AlarmLevellabel.ForeColor = Color.Green;
                            break;
                    }

                    //定时扫描获得的参数
                    if (receivemsg1.Length == 22)
                    {
                        string tv1 = receivemsg1.Substring(0, 2);      //截取指定位置的字符串
                        int tvint1 = Convert.ToInt32(tv1, 16);
                        string tvin1 = Convert.ToString(tvint1, 10);
                        test1 = tvin1;
                        tvi = tvint1;

                        string tv2 = receivemsg1.Substring(10, 4);      //截取指定位置的字符串
                        int tvint2 = Convert.ToInt32(tv2, 16);
                        string tvin2 = Convert.ToString(tvint2, 10);
                        test2 = tvin2;      //故障

                        string tv3 = receivemsg1.Substring(14, 4);      //截取指定位置的字符串
                        int tvint3 = Convert.ToInt32(tv3, 16);
                        string tvin3 = Convert.ToString(tvint3, 10);
                        test3 = tvin3;      //报警级别

                        if ((test2 == "1") || (test3 != "0"))
                        {
                            devicesearch.Nodes[0].BackColor = System.Drawing.Color.Yellow;
                            devicesearch.Nodes[0].ImageIndex = 8;
                            devicesearch.Nodes[0].SelectedImageIndex = 8;
                        }
                        else
                        {
                            devicesearch.Nodes[0].BackColor = System.Drawing.Color.Transparent;
                            //if ((fault==0)&& (warn == 0)&& (smoke1 == 0)&& (smoke2 == 0)&& (fire1 == 0) && (fire2 == 0))
                            //{
                            devicesearch.Nodes[0].ImageIndex = 9;
                            devicesearch.Nodes[0].SelectedImageIndex = 5;
                            //}
                        }
                        if (test3 != "0")
                        {
                            devicesearch.Nodes[0].ImageIndex = 7;
                            devicesearch.Nodes[0].SelectedImageIndex = 7;
                        }
                        else
                        {
                            devicesearch.Nodes[0].ImageIndex = 9;
                            devicesearch.Nodes[0].SelectedImageIndex = 5;
                        }

                        if ((warn != 0) || (smoke1 != 0) || (smoke2 != 0) || (fire1 != 0) || (fire2 != 0))
                        {
                            devicesearch.Nodes[0].BackColor = System.Drawing.Color.Red;
                            devicesearch.Nodes[0].ImageIndex = 7;
                            devicesearch.Nodes[0].SelectedImageIndex = 7;
                        }
                        else
                        {
                            if (fault != 0)
                            {
                                devicesearch.Nodes[0].ImageIndex = 8;
                                devicesearch.Nodes[0].SelectedImageIndex = 8;
                            }
                            else
                            {
                                devicesearch.Nodes[0].ImageIndex = 9;
                                devicesearch.Nodes[0].SelectedImageIndex = 5;
                            }
                        }

                        if (test2 == "1")
                        {
                            devicesearch.Nodes[0].Nodes[Nod[tvi]].BackColor = System.Drawing.Color.Yellow;
                            devicesearch.Nodes[0].Nodes[Nod[tvi]].ImageIndex = 3;
                            devicesearch.Nodes[0].Nodes[Nod[tvi]].SelectedImageIndex = 3;

                            if (faultflag[tvi] != 1)
                            {
                                fault++;
                                AlarmQuery.alarm_recording("其他设备故障", "网关内有" + fault + "台设备故障");
                            }
                            faultflag[tvi] = 1;
                            toolStripStatusLabel2.Text = Convert.ToString(fault, 10);

                            if (fault == 0)
                            {
                                toolStripStatusLabel2.BackColor = Color.Transparent;
                                toolStripStatusLabel3.BackColor = Color.Transparent;
                            }
                            else
                            {
                                toolStripStatusLabel2.BackColor = Color.Yellow;
                                toolStripStatusLabel3.BackColor = Color.Yellow;
                            }
                        }
                        else
                        {
                            devicesearch.Nodes[0].Nodes[Nod[tvi]].BackColor = System.Drawing.Color.Transparent;
                            devicesearch.Nodes[0].Nodes[Nod[tvi]].ImageIndex = 4;
                            devicesearch.Nodes[0].Nodes[Nod[tvi]].SelectedImageIndex = 0;
                            if (test3 != "0")
                            {
                                devicesearch.Nodes[0].Nodes[Nod[tvi]].BackColor = System.Drawing.Color.Red;
                                devicesearch.Nodes[0].Nodes[Nod[tvi]].ImageIndex = 2;
                                devicesearch.Nodes[0].Nodes[Nod[tvi]].SelectedImageIndex = 2;
                                switch (test3)
                                {
                                    case "1":
                                        if (warnflag[tvi] != 1)
                                        {
                                            warn++;
                                            AlarmQuery.alarm_recording("其他设备警告", "网关内有" + warn + "台设备预警");
                                        }
                                        warnflag[tvi] = 1;
                                        toolStripStatusLabel4.Text = Convert.ToString(warn, 10);
                                        if (warn == 0)
                                        {
                                            toolStripStatusLabel4.BackColor = Color.Transparent;
                                            toolStripStatusLabel5.BackColor = Color.Transparent;
                                        }
                                        else
                                        {
                                            toolStripStatusLabel4.BackColor = Color.Red;
                                            toolStripStatusLabel5.BackColor = Color.Red;
                                        }
                                        break;
                                    case "2":
                                        if (smoke1flag[tvi] != 1)
                                        {
                                            smoke1++;
                                            AlarmQuery.alarm_recording("其他设备警告", "网关内有" + smoke1 + "台设备烟雾1告警");
                                        }
                                        smoke1flag[tvi] = 1;
                                        toolStripStatusLabel6.Text = Convert.ToString(smoke1, 10);
                                        if (smoke1 == 0)
                                        {
                                            toolStripStatusLabel6.BackColor = Color.Transparent;
                                            toolStripStatusLabel7.BackColor = Color.Transparent;
                                        }
                                        else
                                        {
                                            toolStripStatusLabel6.BackColor = Color.Red;
                                            toolStripStatusLabel7.BackColor = Color.Red;
                                        }
                                        break;
                                    case "3":
                                        if (smoke2flag[tvi] != 1)
                                        {
                                            smoke2++;
                                            AlarmQuery.alarm_recording("其他设备警告", "网关内有" + smoke2 + "台设备烟雾2告警");
                                        }
                                        smoke2flag[tvi] = 1;
                                        toolStripStatusLabel8.Text = Convert.ToString(smoke2, 10);
                                        if (smoke2 == 0)
                                        {
                                            toolStripStatusLabel8.BackColor = Color.Transparent;
                                            toolStripStatusLabel9.BackColor = Color.Transparent;
                                        }
                                        else
                                        {
                                            toolStripStatusLabel8.BackColor = Color.Red;
                                            toolStripStatusLabel9.BackColor = Color.Red;
                                        }
                                        break;
                                    case "4":
                                        if (fire1flag[tvi] != 1)
                                        {
                                            fire1++;
                                            AlarmQuery.alarm_recording("其他设备警告", "网关内有" + fire1 + "台设备火警1告警");
                                        }
                                        fire1flag[tvi] = 1;
                                        toolStripStatusLabel10.Text = Convert.ToString(fire1, 10);
                                        if (fire1 == 0)
                                        {
                                            toolStripStatusLabel10.BackColor = Color.Transparent;
                                            toolStripStatusLabel11.BackColor = Color.Transparent;
                                        }
                                        else
                                        {
                                            toolStripStatusLabel10.BackColor = Color.Red;
                                            toolStripStatusLabel11.BackColor = Color.Red;
                                        }
                                        break;
                                    case "5":
                                        if (fire2flag[tvi] != 1)
                                        {
                                            fire2++;
                                            AlarmQuery.alarm_recording("其他设备警告", "网关内有" + fire2 + "台设备火警2告警");
                                        }
                                        fire2flag[tvi] = 1;
                                        toolStripStatusLabel12.Text = Convert.ToString(fire2, 10);
                                        if (fire2 == 0)
                                        {
                                            toolStripStatusLabel12.BackColor = Color.Transparent;
                                            toolStripStatusLabel13.BackColor = Color.Transparent;
                                        }
                                        else
                                        {
                                            toolStripStatusLabel12.BackColor = Color.Red;
                                            toolStripStatusLabel13.BackColor = Color.Red;
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                devicesearch.Nodes[0].Nodes[Nod[tvi]].BackColor = System.Drawing.Color.Transparent;
                                devicesearch.Nodes[0].Nodes[Nod[tvi]].ImageIndex = 4;
                                devicesearch.Nodes[0].Nodes[Nod[tvi]].SelectedImageIndex = 0;

                            }
                        }
                    }

                    string devi = deviceaddress1 + "03002C000F";
                    if (SetIP.newclient != null)
                    {
                        SetIP.SendData(devi);
                    }
                    rxmsg2 = SetIP.ReceiveMsg();        //接收数据
                                                        //textBox1.Text = rxmsg2;
                    try
                    {
                        //labelpipe1.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(6, 4), 16), 10);
                        if (Convert.ToString(Convert.ToInt32(rxmsg2.Substring(6, 4), 16), 10) == "1")
                        {
                            labelpipe1.Text = "开";
                        }
                        else
                        {
                            labelpipe1.Text = "关";
                        }
                        //labelpipe2.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(10, 4), 16), 10);
                        if (Convert.ToString(Convert.ToInt32(rxmsg2.Substring(10, 4), 16), 10) == "1")
                        {
                            labelpipe2.Text = "开";
                        }
                        else
                        {
                            labelpipe2.Text = "关";
                        }
                        //labelpipe3.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(14, 4), 16), 10);
                        if (Convert.ToString(Convert.ToInt32(rxmsg2.Substring(14, 4), 16), 10) == "1")
                        {
                            labelpipe3.Text = "开";
                        }
                        else
                        {
                            labelpipe3.Text = "关";
                        }
                        //labelpipe4.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(18, 4), 16), 10);
                        if (Convert.ToString(Convert.ToInt32(rxmsg2.Substring(18, 4), 16), 10) == "1")
                        {
                            labelpipe4.Text = "开";
                        }
                        else
                        {
                            labelpipe4.Text = "关";
                        }
                        //labelSmokeLevel.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(22, 4), 16), 10);
                        switch (Convert.ToString(Convert.ToInt32(rxmsg2.Substring(22, 4), 16), 10))
                        {
                            case "1":
                                labelSmokeLevel.Text = "极灵敏";
                                break;
                            case "2":
                                labelSmokeLevel.Text = "灵敏";
                                break;
                            case "3":
                                labelSmokeLevel.Text = "极不灵敏";
                                break;
                            case "4":
                                labelSmokeLevel.Text = "自定义";
                                break;
                            default:
                                break;
                        }
                        labelCurrentDeviceAddress.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(38, 4), 16), 10);
                        labelFireAlarm2.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(46, 4), 16), 10);
                        labelFireAlarm1.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(50, 4), 16), 10);
                        labelSmoke2.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(54, 4), 16), 10);
                        labelSmoke1.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(58, 4), 16), 10);
                        labelwarning.Text = Convert.ToString(Convert.ToInt32(rxmsg2.Substring(62, 4), 16), 10);
                    }
                    catch
                    { }
                    detecflog = true;
                }


            }
            catch (Exception)
            { }
        }
        private void Detection()        //轮询检测多台设备故障
        {
            while (true)
            {
                try
                {
                    if (detecflog == true)
                    {
                        detecflog = false;
                        m++;
                        if (m > 50)
                        {
                            m = 0;
                        }
                        string strd = m.ToString("X2");      //十进制转十六进制
                        if (strd.Length < 2)
                        {
                            strd = "0" + strd;
                        }
                        string data1 = strd + "04000E0003";
                        if (SetIP.newclient != null)
                        {
                            SetIP.SendData(data1);
                        }
                        receivemsg1 = SetIP.ReceiveMsg();        //接收数据

                        devtimerflog = true;
                    }
                }
                catch (Exception)
                { }

            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        string Resetstr = "";

        private void Reset_Click(object sender, EventArgs e)
        {
            devicetimer.Enabled = false;

            Resetstr = deviceaddress1 + "06003B0001";
            if (SetIP.newclient != null)
            {
                SetIP.SendData(Resetstr);
            }
            SetIP.ReceiveMsg();
            devicetimer.Enabled = true;
        }

        private void frmEquipmentState_Load(object sender, EventArgs e)
        {
            devicesearch.Nodes[0].Text = "ccdsnet";
        }
    }
}






