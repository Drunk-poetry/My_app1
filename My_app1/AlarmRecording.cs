using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace My_app1.PMSClass
{
    class AlarmRecording
    {
        private static String toSqlString(String str)
        {
            string str1 = " '" + str + "' ";
            return str1;
        }

        public static void alarm_recording(string type,string alarm)
        {
            long alarm_ID_int = get_alarm_ID();
            alarm_ID_int ++;
            string alarm_ID_string = Convert.ToString(alarm_ID_int);
            SqlConnection conn = PMSClass.DBConnection.MyConnection();  //创建数据库连接对象
            conn.Open();    //连接到SQL数据库
            SqlCommand cmd = new SqlCommand("insert into tb_HistoryAlarm(ID,Type,Alarm,Time) values(" 
                + toSqlString(alarm_ID_string) + ","
                + toSqlString(type) + ","
                + toSqlString(alarm) + ","
                + toSqlString(DateTime.Now.ToString()) +
                ");", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static long get_alarm_ID()
        {
            long alarm_ID = 0;

            SqlConnection conn = PMSClass.DBConnection.MyConnection();  //创建数据库连接对象
            conn.Open();    //连接到SQL数据库
            SqlCommand cmd = new SqlCommand("select ID from tb_HistoryAlarm order by ID desc;", conn);//创建数据库命令对象
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                alarm_ID = reader.GetInt64(reader.GetOrdinal("ID"));
            }
            conn.Close();

            return alarm_ID;
        }
    }
}
