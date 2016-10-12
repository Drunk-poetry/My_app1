using Core.DBUtility;
using DBCLibrary;
using My_app1.PMSClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_app1
{
    public partial class frmChangeUser : Form
    {
        frmMain userpwd;
        public frmChangeUser(frmMain userpwd)
        {
            InitializeComponent();
            this.userpwd = userpwd;
        }

        public static string quanxian;
        //DBOperate userdb = new DBOperate();//创建数据库操作对象
        private void frmChangeUser_Load(object sender, EventArgs e)
        {
            Object[] mf4 = new Object[] { };
            string strSql = "select * from tb_User where ID < 4";
            OleDbConnection oldbcon = OleDbHelper.GetOleDbConnection(); 
            DataSet ds = OleDbHelper.ExecuteDatasetFill(strSql, "UserInfo", mf4);     //创建DataSet实例
            
            Superadministrator.Text = ds.Tables["UserInfo"].Rows[0][1].ToString();
            administrator.Text = ds.Tables["UserInfo"].Rows[1][1].ToString();
            averageuser.Text = ds.Tables["UserInfo"].Rows[2][1].ToString();

            oldbcon.Close();
        }
        private void ChangeUserbutton_Click(object sender, EventArgs e)
        {
            if (NewUserbox.Text.Trim() != "" && quanxian != "")
            {
                //string updatestr = "update tb_User set UserName='" + NewUserbox.Text.Trim() + "'where UserLimit='" + quanxian + "'";
                //userdb.OperateData(updatestr);

                Object[] mf4 = new Object[] { };
                string updatestr = "update tb_User set UserName='" + NewUserbox.Text.Trim() + "'where UserLimit='" + quanxian + "'";
                OleDbConnection oldbcon = OleDbHelper.GetOleDbConnection();
                OleDbHelper.ExecuteNonQuery(updatestr, mf4);
                oldbcon.Close();

                MessageBox.Show("用户名修改成功,系统需要注销或重启后生效！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OperationQuery.Event_Record(userpwd.Limit, "用户名修改成功");//事件录入（用户级别，自定义字符串操作）
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExitChangeUserbutton_Click(object sender, EventArgs e)
        {
            this.Hide();        //隐藏窗体
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quanxian = this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString();
        }
    }
}
