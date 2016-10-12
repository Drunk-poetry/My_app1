using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using Core.DBUtility;

namespace My_app1.PMSClass
{
    class RecordingUsing
    {
        public static void AlarmShow(ListView listView1, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
        {
            string dtp1 = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string dtp2 = dateTimePicker2.Value.ToString("yyyy/MM/dd");

            dtp1 = delete_m_d_zero(dtp1);//数据库需要去掉10以下月份的前一个0
            dtp2 = add_oneday(dtp2);//数据库默认识别每天的00：00，因此需要加一天
            dtp2 = delete_m_d_zero(dtp2);

            //SqlConnection conn = PMSClass.DBConnection.MyConnection();  //创建数据库连接对象
            //SqlDataReader datareader;
            //conn.Open();    //连接到SQL数据库
            //SqlCommand cmd = new SqlCommand("select * from tb_HistoryAlarm where Time between '" + dtp1 + "' and '" + dtp2 + "' order by ID asc", conn);
            //datareader = cmd.ExecuteReader();

            Object[] mf4 = new Object[] { };
            string strSql = "select * from tb_HistoryAlarm where Time between '" + dtp1 + "' and '" + dtp2 + "' order by ID asc";
            OleDbConnection oldbcon = OleDbHelper.GetOleDbConnection();
            OleDbDataReader datareader = OleDbHelper.ExecuteReader(strSql, mf4);

            listView1.Items.Clear();//清除表格

            if (!datareader.HasRows)
            {
                MessageBox.Show("没有查询到数据");
            }
            while (datareader.Read())
            {
                ListViewItem lvi1 = new ListViewItem(datareader["ID"].ToString());
                lvi1.SubItems.Add(datareader["Type"].ToString());
                lvi1.SubItems.Add(datareader["Alarm"].ToString());
                lvi1.SubItems.Add(datareader["Time"].ToString());
                listView1.Items.Add(lvi1);
            }
            oldbcon.Close();
        }
        public static void OperationShow(ListView listView1, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
        {
            string dtp1 = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string dtp2 = dateTimePicker2.Value.ToString("yyyy/MM/dd");

            dtp1 = delete_m_d_zero(dtp1);//数据库需要去掉10以下月份的前一个0
            dtp2 = add_oneday(dtp2);//数据库默认识别每天的00：00，因此需要加一天
            dtp2 = delete_m_d_zero(dtp2);

            //SqlConnection conn = PMSClass.DBConnection.MyConnection();  //创建数据库连接对象
            //SqlDataReader datareader;
            //conn.Open();    //连接到SQL数据库
            //SqlCommand cmd = new SqlCommand("select * from tb_SysLog where Time between '" + dtp1 + "' and '" + dtp2 + "' order by ID asc", conn);
            //datareader = cmd.ExecuteReader();

            Object[] mf4 = new Object[] { };
            string strSql = "select * from tb_SysLog where Time between '" + dtp1 + "' and '" + dtp2 + "' order by ID asc";
            OleDbConnection oldbcon = OleDbHelper.GetOleDbConnection();
            OleDbDataReader datareader = OleDbHelper.ExecuteReader(strSql, mf4);

            listView1.Items.Clear();//清除表格

            if (!datareader.HasRows)
            {
                MessageBox.Show("没有查询到数据");
            }
            while (datareader.Read())
            {
                ListViewItem lvi1 = new ListViewItem(datareader["ID"].ToString());
                lvi1.SubItems.Add(datareader["Levels"].ToString());
                lvi1.SubItems.Add(datareader["Syslog"].ToString());
                lvi1.SubItems.Add(datareader["Time"].ToString());
                listView1.Items.Add(lvi1);
            }
            oldbcon.Close();
        }
        private static string delete_m_d_zero(string dtp)
        {
            string dtp_m_split = "";
            string dtp_d_split = "";

            dtp_m_split = dtp.Substring(5, 2);      //yyyy/MM/dd
            dtp_d_split = dtp.Substring(8, 2);

            if (dtp_m_split.Substring(0, 1) == "0")
            {
                dtp_m_split = dtp_m_split.Substring(1, 1);
                dtp = dtp.Remove(5, 2);                 //2016//01
                dtp = dtp.Insert(5, dtp_m_split);       //2016/10/01 
                if (dtp.Substring(7, 1) == "0")
                {
                    dtp_d_split = dtp_d_split.Substring(1, 1);
                    dtp = dtp.Remove(7, 2);
                    dtp = dtp.Insert(7, dtp_d_split);
                }
            }
            else
            {
                if (dtp.Substring(8, 1) == "0")
                {
                    dtp_d_split = dtp_d_split.Substring(1, 1);
                    dtp = dtp.Remove(8, 2);
                    dtp = dtp.Insert(8, dtp_d_split);
                }
            }
            return dtp;
        }
        private static string add_oneday(string dtp)
        {
            string dtp_d_split = dtp.Substring(8, 2);
            Int16 dtp_d_split_int = Convert.ToInt16(dtp_d_split);
            dtp_d_split_int++;
            dtp_d_split = Convert.ToString(dtp_d_split_int);
            if (dtp_d_split.Length <= 1)
            {
                dtp_d_split = "0"+dtp_d_split;
            }
            dtp = dtp.Remove(8, 2);
            dtp = dtp.Insert(8, dtp_d_split);
            return dtp;
        }
    }
}

