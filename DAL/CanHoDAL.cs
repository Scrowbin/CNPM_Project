using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT;


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
                    MaCanHo = row["MA_CAN_HO"].ToString(),
                    MaChuNha = row["MA_CHU_NHA"].ToString(),
                    TenCanHo = row["TEN_CAN_HO"].ToString(),
                    DiaChi = row["DIA_CHI"].ToString(),
                    LoaiCanHo = row["LOAI_CAN_HO"] == DBNull.Value ? null : row["LOAI_CAN_HO"].ToString(),
                    DienTich = row["DIEN_TICH"] == DBNull.Value ? null : (float?)Convert.ToDouble(row["DIEN_TICH"]),
                    GiaThueDaiHan = Convert.ToInt32(row["GIA_THUE_DAI_HAN"]),
                    GiaThueNganHan = Convert.ToInt32(row["GIA_THUE_NGAN_HAN"])
                };
                list.Add(ch);
            }
            return list;
        }

        public int AddCanHo(CanHo ch)
        {
            string sql = $"INSERT INTO CAN_HO (MA_CAN_HO, MA_CHU_NHA, TEN_CAN_HO, DIA_CHI, LOAI_CAN_HO, DIEN_TICH, GIA_THUE_DAI_HAN, GIA_THUE_NGAN_HAN) " +
                         $"VALUES ('{ch.MaCanHo}', '{ch.MaChuNha}', '{ch.TenCanHo}', '{ch.DiaChi}', '{ch.LoaiCanHo}', {ch.DienTich}, {ch.GiaThueDaiHan}, {ch.GiaThueNganHan})";
            return db.ExecuteSQL(sql);
        }

        public int UpdateCanHo(CanHo ch)
        {
            string sql = $"UPDATE CAN_HO SET MA_CHU_NHA = '{ch.MaChuNha}', TEN_CAN_HO = '{ch.TenCanHo}', DIA_CHI = '{ch.DiaChi}', " +
                         $"LOAI_CAN_HO = '{ch.LoaiCanHo}', DIEN_TICH = {ch.DienTich}, GIA_THUE_DAI_HAN = {ch.GiaThueDaiHan}, GIA_THUE_NGAN_HAN = {ch.GiaThueNganHan} " +
                         $"WHERE MA_CAN_HO = '{ch.MaCanHo}'";
            return db.ExecuteSQL(sql);
        }

        public int DeleteCanHo(string maCanHo)
        {
            string sql = $"DELETE FROM CAN_HO WHERE MA_CAN_HO = '{maCanHo}'";
            return db.ExecuteSQL(sql);
        }

        public List<CanHo> GetCanHoByMaChuNha(string maChuNha)
        {
            List<CanHo> list = new List<CanHo>();
            string sql = $"SELECT * FROM CAN_HO WHERE MA_CHU_NHA = '{maChuNha}'";
            DataTable  dt = db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                CanHo ch = new CanHo
                {
                    MaCanHo = row["MA_CAN_HO"].ToString(),
                    MaChuNha = row["MA_CHU_NHA"].ToString(),
                    TenCanHo = row["TEN_CAN_HO"].ToString(),
                    DiaChi = row["DIA_CHI"].ToString(),
                    LoaiCanHo = row["LOAI_CAN_HO"] == DBNull.Value ? null : row["LOAI_CAN_HO"].ToString(),
                    DienTich = row["DIEN_TICH"] == DBNull.Value ? null : (float?)Convert.ToDouble(row["DIEN_TICH"]),
                    GiaThueDaiHan = Convert.ToInt32(row["GIA_THUE_DAI_HAN"]),
                    GiaThueNganHan = Convert.ToInt32(row["GIA_THUE_NGAN_HAN"])
                };
                list.Add(ch);
            }
            return list;
        }
    }
}
