using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DAL
{
    public class ChuNhaDAL
    {
        private dbConnect db;

        public ChuNhaDAL(string cn)
        {
            db = new dbConnect(cn);
        }

        public List<ChuNha> GetAllChuNha()
        {
            List<ChuNha> list = new List<ChuNha>();
            string sql = "SELECT * FROM CHU_NHA";
            DataTable dt = db.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                ChuNha ch = new ChuNha
                {
                    MaChuNha = row["MA_CN"].ToString(),
                    HoTen = row["TEN_CN"].ToString(),
                    CCCD = row["CCCD"].ToString(),
                    SDT = row["SDT"].ToString(),
                    DiaChi = row["DIA_CHI"].ToString(),
                    Email = row["EMAIL"].ToString(),
                    STK = row["STK"].ToString()
                };
                list.Add(ch);
            }

            return list; // Trả về danh sách ChuNha
        }
        public int AddChuNha(ChuNha ch)
        {
            string sql = $"INSERT INTO CHU_NHA (MA_CN, TEN_CN, CCCD, SDT, DIA_CHI, EMAIL, STK) " +
                         $"VALUES ('{ch.MaChuNha}', '{ch.HoTen}', '{ch.CCCD}' '{ch.SDT}', '{ch.DiaChi}', '{ch.Email}', '{ch.STK}')";
            return db.ExecuteSQL(sql);
        }
        public int UpdateChuNha(ChuNha ch)
        {
            string sql = $"UPDATE CHU_NHA SET TEN_CN = '{ch.HoTen}', CCCD = '{ch.CCCD}', SDT = '{ch.SDT}', DIA_CHI = '{ch.DiaChi}', EMAIL = '{ch.Email}', STK = '{ch.STK}' " +
                         $"WHERE MA_CN = '{ch.MaChuNha}'";
            return db.ExecuteSQL(sql);
        }
        public int DeleteChuNha(string maChuNha)
        {
            string sql = $"DELETE FROM CHU_NHA WHERE MA_CN = '{maChuNha}'";
            return db.ExecuteSQL(sql);
        }
        public List<ChuNha> GetChuNhaByMaChuNha(string maChuNha)
        {
            List<ChuNha> list = new List<ChuNha>();
            string sql = $"SELECT * FROM CHU_NHA WHERE MA_CN = '{maChuNha}'";
            DataTable dt = db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                ChuNha ch = new ChuNha
                {
                    MaChuNha = row["MA_CN"].ToString(),
                    HoTen = row["TEN_CN"].ToString(),
                    SDT = row["SDT"].ToString(),
                    CCCD = row["CCCD"].ToString(),
                    Email = row["EMAIL"].ToString()
                };
                list.Add(ch);
            }
            return list; // Trả về danh sách ChuNha
        }
    }
}
