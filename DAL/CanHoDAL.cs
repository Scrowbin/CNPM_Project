using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class CanHoDAL
    {
        private dbConnect db;

        public CanHoDAL(string cn)
        {
            db = new dbConnect(cn);
        }
        public List<CanHo> GetAllCanHo()
        {
            List<CanHo> list = new List<CanHo>();
            string sql = "SELECT * FROM CAN_HO";
            DataTable dt = db.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                CanHo ch = new CanHo
                {
                    MaCanHo = row["MA_CH"].ToString(),
                    MaChuNha = row["MA_CN"].ToString(),
                    TenCanHo = row["TEN_CH"].ToString(),
                    DiaChi = row["DIA_CHI"].ToString(),
                    LoaiCanHo = row["LOAI_CAN_HO"] == DBNull.Value ? null : row["LOAI_CAN_HO"].ToString(),
                    DienTich = row["DIEN_TICH"] == DBNull.Value ? null : (float?)Convert.ToDecimal(row["DIEN_TICH"]),
                    GiaThueDaiHan = Convert.ToInt32(row["GIA_THUE_DAI_HAN"]),
                    GiaThueNganHan = Convert.ToInt32(row["GIA_THUE_NGAN_HAN"])
                };
                list.Add(ch);
            }
            return list;
        }

        public int AddCanHo(CanHo ch)
        {
            string sql = $"INSERT INTO CAN_HO (MA_CH, MA_CN, TEN_CH, DIA_CHI, LOAI_CAN_HO, DIEN_TICH, GIA_THUE_DAI_HAN, GIA_THUE_NGAN_HAN) " +
                         $"VALUES ('{ch.MaCanHo}', '{ch.MaChuNha}', '{ch.TenCanHo}', '{ch.DiaChi}', '{ch.LoaiCanHo}', {ch.DienTich}, {ch.GiaThueDaiHan}, {ch.GiaThueNganHan})";
            return db.ExecuteSQL(sql);
        }

        public int UpdateCanHo(CanHo ch)
        {
            string sql = $"UPDATE CAN_HO SET MA_CN = '{ch.MaChuNha}', TEN_CH = '{ch.TenCanHo}', DIA_CHI = '{ch.DiaChi}', " +
                         $"LOAI_CAN_HO = '{ch.LoaiCanHo}', DIEN_TICH = {ch.DienTich}, GIA_THUE_DAI_HAN = {ch.GiaThueDaiHan}, GIA_THUE_NGAN_HAN = {ch.GiaThueNganHan} " +
                         $"WHERE MA_CH = '{ch.MaCanHo}'";
            return db.ExecuteSQL(sql);
        }

        public int DeleteCanHo(string maCanHo)
        {
            string sql = $"DELETE FROM CAN_HO WHERE MA_CH = '{maCanHo}'";
            return db.ExecuteSQL(sql);
        }

        public CanHo GetCanHoByMaChuNha(string maChuNha)
        {
            string sql = $"SELECT * FROM CAN_HO WHERE MA_CN = '{maChuNha}'";
            DataTable dt = db.GetData(sql);
            if (dt.Rows.Count > 0) // Kiểm tra nếu có kết quả
            {
                DataRow row = dt.Rows[0]; // Lấy dòng đầu tiên
                CanHo ch = new CanHo
                {
                    MaCanHo = row["MA_CH"].ToString(),
                    MaChuNha = row["MA_CN"].ToString(),
                    TenCanHo = row["TEN_CH"].ToString(),
                    DiaChi = row["DIA_CHI"].ToString(),
                    LoaiCanHo = row["LOAI_CAN_HO"] == DBNull.Value ? null : row["LOAI_CAN_HO"].ToString(),
                    DienTich = row["DIEN_TICH"] == DBNull.Value ? null : (float?)Convert.ToDouble(row["DIEN_TICH"]),
                    GiaThueDaiHan = Convert.ToInt32(row["GIA_THUE_DAI_HAN"]),
                    GiaThueNganHan = Convert.ToInt32(row["GIA_THUE_NGAN_HAN"])
                };
                return ch;
            }
            return null; // Nếu không tìm thấy, trả về null
        }
    }
}
