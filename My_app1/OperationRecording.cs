using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace My_app1.PMSClass
{ 
    class OperationRecording
    {
        private static string ID_string;
        private static long ID_int;

        private static String toSqlString(String str)
        {
            string str1 = " '" + str + "' ";
            return str1;
        }

        public static void Event_Record(string authority , string operation)
        {
            ID_int = get_event_ID();
            ID_int++;
            ID_string = Convert.ToString(ID_int);

            SqlConnection conn = PMSClass.DBConnection.MyConnection();  //创建数据库连接对象
            conn.Open();    //连接到SQL数据库
            SqlCommand cmd = new SqlCommand("insert into tb_SysLog(ID,Levels,SysLog,Time) values("
                + toSqlString(ID_string) + ","
                + toSqlString(authority) + ","
                + toSqlString("有登陆操作") + ","
                + toSqlString(DateTime.Now.ToString()) + ");", conn);//创建数据库命令对象
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static string author_identification(string name,string pwd)
        {
            string user = "";

            SqlConnection conn = PMSClass.DBConnection.MyConnection();  //创建数据库连接对象
            conn.Open();    //连接到SQL数据库
            SqlCommand cmd = new SqlCommand("select * from tb_User where UserName = " + toSqlString(name) + " and UserPwd = " + toSqlString(pwd) + ";", conn);//创建数据库命令对象
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = reader.GetString(reader.GetOrdinal("UserLimit"));
            }
            conn.Close();

            return user;
        }

        public static long get_event_ID()
        {
            long event_ID = 0;

            SqlConnection conn = PMSClass.DBConnection.MyConnection();  //创建数据库连接对象
            conn.Open();    //连接到SQL数据库
            SqlCommand cmd = new SqlCommand("select ID from tb_SysLog order by ID desc;", conn);//创建数据库命令对象
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                event_ID = reader.GetInt64(reader.GetOrdinal("ID"));
            }
            conn.Close();

            return event_ID;
        }

        public static void Login_time_Record(String name , String t)
        {
            SqlConnection conn = PMSClass.DBConnection.MyConnection();  //创建数据库连接对象
            conn.Open();    //连接到SQL数据库
            SqlCommand cmd = new SqlCommand("update tb_User set LoginTime=" + toSqlString(t) + " where UserName=" + toSqlString(name) + ";",conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        
    }
}
