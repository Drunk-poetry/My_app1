
using DBCLibrary;
using My_app1.PMSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_app1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)      //退出
        {
            try
            {
                Application.Exit();     //退出软件
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //DBOperate operate = new DBOperate();//创建操作数据库对象
        frmMain Main = new frmMain();   //创建主窗体对象
        public string name = "";
        private void button1_Click(object sender, EventArgs e)      //确认登录
        {
            try
            {
                if (txtUserName.Text == "" || txtUserPwd.Text == "")       //判断用户名和密码是否为空
                {
                    MessageBox.Show("用户名或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); //弹出消息对话框
                    return;     //退出事件
                }
                else
                {
                    name = txtUserName.Text.Trim();  //移除用户名前部和后部的空格
                    string pwd = txtUserPwd.Text.Trim();   //移除密码前部和后部的空格

                    string authority = OperationQuery.author_identification(name, pwd);//获取响应名字的权限名字UserLimit
                    Main.Limit = authority;
                    OperationQuery.Event_Record(authority, "登录系统");//事件录入（用户级别，自定义字符串操作）
                    OperationQuery.Login_time_Record(name, DateTime.Now.ToString());

                    //AlarmRecording.alarm_recording("type test", "alarm test");

                    if (authority == "")
                    {
                        txtUserName.Text = "";      //清空用户名
                        txtUserPwd.Text = "";       //清空密码
                        MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);  //弹出消息对话框
                    }
                    else
                    {
                        this.Hide();        //隐藏窗体
                        Main.User = name;
                        Main.Logintime = DateTime.Now.ToString();
                        Main.WindowState = FormWindowState.Maximized;
                        Main.Show();
                    }
                    //frmEquipmentState EquipmentStatelogin = new frmEquipmentState(SetIP);
                    //EquipmentStatelogin.MdiParent = Main;                     //设置窗体对象的父窗体
                    //EquipmentStatelogin.WindowState = FormWindowState.Maximized;
                    //EquipmentStatelogin.Show();
                }
                
            }
            catch (Exception ex)     //捕获异常
            {
                //MessageBox.Show(ex.Message);    //弹出消息对话框
            }
        }
    }
}

