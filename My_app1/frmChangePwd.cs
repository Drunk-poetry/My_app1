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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_app1
{
    public partial class frmChangePwd : Form
    {
        //DBOperate operate = new DBOperate();//创建数据库操作对象
        frmMain username;
        public frmChangePwd(frmMain username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void frmChangePwd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text.Trim() == "" || txtNewPwd.Text.Trim() == "" || txtNewPwdOK.Text.Trim() == "")
            {
                MessageBox.Show("密码设置不能为空！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtNewPwd.Text.Trim().Length < 6)
                {
                    MessageBox.Show("密码设置不能低于六位！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOldPwd.Text = "";
                    txtNewPwd.Text = "";
                    txtNewPwdOK.Text = "";
                }
                else
                {
                    string str = "select count(*) from tb_User where UserName='"+ username.User + "'and UserPwd='"+this.txtOldPwd.Text.Trim()+"'";
                    Int32 i = OperationQuery.HumanNum(str);
                    if (i > 0)
                    {
                        if (txtNewPwd.Text.Trim() != txtNewPwdOK.Text.Trim())
                        {
                            MessageBox.Show("两次密码不一致","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            string updatestr = "update tb_User set UserPwd='" + txtNewPwdOK.Text.Trim() + "'where UserName='" + username.User + "'";
                            OperationQuery.OperateData(updatestr);
                            MessageBox.Show("密码修改成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            OperationQuery.Event_Record(username.Limit, "密码修改成功");//事件录入（用户级别，自定义字符串操作）
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("旧密码错误","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
