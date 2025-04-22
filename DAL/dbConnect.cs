using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class dbConnect
    {
        private SqlConnection conn;

        public dbConnect()
        {
            conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True");
        }


        // Lấy dự liệu bằng câu lệnh trực tiếp
        public DataTable GetData(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        // Lấy dữ liệu bằng thủ tục
        public DataTable GetData(string procName, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(procName, conn);
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        // Thực thi câu lệnh SQL, trả về số dòng bị ảnh hưởng
        public int ExecuteSQL(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }

        // Thực thi thủ tục, trả về số dòng bị ảnh hưởng
        public int ExecuteSQL(string procName, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(procName, conn);
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }




    }
}

