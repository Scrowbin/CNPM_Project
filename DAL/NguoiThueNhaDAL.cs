using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class NguoiThueNhaDAL
    {
        private dbConnect db;
        public NguoiThueNhaDAL(string cn)
        {
            db = new dbConnect(cn);
        }
        public List<NguoiThueNha> GetAllNguoiThueNha()
        {
            List<NguoiThueNha> list = new List<NguoiThueNha>();
            string sql = "SELECT * FROM NGUOI_THUE_NHA";
            DataTable dt = db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                NguoiThueNha ch = new NguoiThueNha
                {
                    MaKhachHang = row["MA_KH"].ToString(),
                    HoTen = row["TEN_KH"].ToString(),
                    SDT = row["SDT"].ToString(),
                    CCCDPassport = row["CCCD_PASSPORT"].ToString(),
                    QuocTich = row["QUOC_TICH"].ToString(),
                    DiaChi = row["DIA_CHI"].ToString(),
                    Email = row["EMAIL"].ToString()
                };
                list.Add(ch);
            }
            return list; // Trả về danh sách NguoiThueNha
        }
        public int AddNguoiThueNha(NguoiThueNha ch)
        {
            string sql = $"INSERT INTO NGUOI_THUE_NHA (MA_KH, TEN_KH, SDT, CCCD_PASSPORT, QUOC_TICH, DIA_CHI, EMAIL) " +
                         $"VALUES ('{ch.MaKhachHang}', '{ch.HoTen}', '{ch.SDT}', '{ch.CCCDPassport}', '{ch.QuocTich}', '{ch.DiaChi}', '{ch.Email}')";
            return db.ExecuteSQL(sql);
        }
        public int UpdateNguoiThueNha(NguoiThueNha ch)
        {
            string sql = $"UPDATE NGUOI_THUE_NHA SET TEN_KH = '{ch.HoTen}', SDT = '{ch.SDT}', CCCD_PASSPORT = '{ch.CCCDPassport}', QUOC_TICH = '{ch.QuocTich}', DIA_CHI = '{ch.DiaChi}', EMAIL = '{ch.Email}' " +
                         $"WHERE MA_KH = '{ch.MaKhachHang}'";
            return db.ExecuteSQL(sql);
        }
        public int DeleteNguoiThueNha(string maKhachHang)
        {
            string sql = $"DELETE FROM NGUOI_THUE_NHA WHERE MA_KH = '{maKhachHang}'";
            return db.ExecuteSQL(sql);
        }
        public NguoiThueNha GetNguoiThueNhaByMaKhachHang(string maKhachHang)
        {
            string sql = $"SELECT * FROM NGUOI_THUE_NHA WHERE MA_KH = '{maKhachHang}'";
            DataTable dt = db.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new NguoiThueNha
                {
                    MaKhachHang = row["MA_KH"].ToString(),
                    HoTen = row["TEN_KH"].ToString(),
                    SDT = row["SDT"].ToString(),
                    CCCDPassport = row["CCCD_PASSPORT"].ToString(),
                    QuocTich = row["QUOC_TICH"].ToString(),
                    DiaChi = row["DIA_CHI"].ToString(),
                    Email = row["EMAIL"].ToString()
                };
            }
            return null;
        }
    }
}
