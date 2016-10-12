using Core.DBUtility;
using DBCLibrary;
using My_app1.PMSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_app1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public string User;
        public string Logintime;
        public string Limit;
        //DBOperate operate = new DBOperate();
        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "在线用户：";
            toolStripStatusLabel2.Text = User;
            toolStripStatusLabel3.Text = "          登录时间：";
            toolStripStatusLabel4.Text = Logintime;
            toolStripStatusLabel5.Text = "          系统权限：";
            toolStripStatusLabel6.Text = Limit;
            toolStripStatusLabel7.Text = "                                  深圳市查知科技有限公司";

            Object[] mf4 = new Object[] { };
            string sql = "select * from tb_User where UserName='" + User + "'";
            OleDbConnection oldbcon = OleDbHelper.GetOleDbConnection();
            oldbcon.Open();
            DataSet tableset = OleDbHelper.ExecuteDataset(sql, mf4);
            string lim = tableset.Tables[0].Rows[0][3].ToString();
            oldbcon.Close();

            if (lim == "超级管理员")
            {
                //试用版本功能未开放
                当前数据查询ToolStripMenuItem.Enabled = false;
                工程管理ToolStripMenuItem.Enabled = false;
                GPRS告警ToolStripMenuItem2.Enabled = false;
                主机信息ToolStripMenuItem.Enabled = false;
                license管理ToolStripMenuItem.Enabled = false;
                系统升级ToolStripMenuItem.Enabled = false;
                系统管理ToolStripMenuItem1.Enabled = false;
                参数管理ToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (lim == "一般用户")
                {
                    修改用户名ToolStripMenuItem.Enabled = false;
                    参数管理ToolStripMenuItem.Enabled = false;
                    历史数据查询ToolStripMenuItem.Enabled = false;
                    系统操作记录查询ToolStripMenuItem.Enabled = false;
                    系统管理ToolStripMenuItem1.Enabled = false;

                    //试用版本功能未开放
                    当前数据查询ToolStripMenuItem.Enabled = false;
                    工程管理ToolStripMenuItem.Enabled = false;
                    GPRS告警ToolStripMenuItem2.Enabled = false;
                    主机信息ToolStripMenuItem.Enabled = false;
                    license管理ToolStripMenuItem.Enabled = false;
                    系统升级ToolStripMenuItem.Enabled = false;
                }
                else
                {
                    if (lim == "管理员")
                    {
                        修改用户名ToolStripMenuItem.Enabled = false;
                        系统管理ToolStripMenuItem1.Enabled = false;

                        //试用版本功能未开放
                        当前数据查询ToolStripMenuItem.Enabled = false;
                        工程管理ToolStripMenuItem.Enabled = false;
                        GPRS告警ToolStripMenuItem2.Enabled = false;
                        主机信息ToolStripMenuItem.Enabled = false;
                        license管理ToolStripMenuItem.Enabled = false;
                        系统升级ToolStripMenuItem.Enabled = false;
                        参数管理ToolStripMenuItem.Enabled = false;
                    }
                }
            }
        }

        private void statusStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void 修改口令ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePwd changepwd = new frmChangePwd(this);    //创建修改口令窗体对象
            //changepwd.MdiParent = this;                     //设置窗体对象的父窗体
            changepwd.Show();                               //显示窗体
        }
        private void 连接管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetIP frmSoc = new frmSetIP(this);   //创建窗体对象
            ////frmSoc.MdiParent = this;                     //设置窗体对象的父窗体
            frmSoc.Show();      //显示模式窗体
        }
        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定注销系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                OperationQuery.Event_Record(Limit, "注销系统");//事件录入（用户级别，自定义字符串操作）
                this.Hide();
                frmLogin F_Login = new frmLogin();
                F_Login.Show();
            }
        }
        private void 修改用户名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUser ChangeUser = new frmChangeUser(this);   //创建窗体对象
            //ChangeUser.MdiParent = this;                     //设置窗体对象的父窗体 
            //ChangeUser.WindowState = FormWindowState.Minimized;
            ChangeUser.Show();      //显示模式窗体
        }
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出本系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                //Application.Exit();
                System.Environment.Exit(0);
            }
        }
        private void 远程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void frmMaintime_Tick(object sender, EventArgs e)           //刷新窗口数据显示
        {
            toolStripStatusLabel8.Text = DateTime.Now.ToLongTimeString();      //刷新系统时间显示
            //frmEquipmentState.toolStripStatusLabel1.Text = DateTime.Now.ToLocalTime().ToString();
        }
        private void 设备状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmEquipmentState EquipmentState = new frmEquipmentState();   //创建窗体对象
            //EquipmentState.MdiParent = this;                     //设置窗体对象的父窗体            
            //EquipmentState.Dock = DockStyle.Fill;
            //EquipmentState.WindowState = FormWindowState.Maximized;
            //EquipmentState.Show();      //显示模式窗体
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 历史数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoryAlarm hisala = new frmHistoryAlarm(this);
            hisala.Show();
        }

        private void 系统操作记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSysLog syslog = new frmSysLog(this);
            syslog.Show();
        }
    }
}

