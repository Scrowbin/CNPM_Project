using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class NotifyDAL
    {
        private dbConnect db;

        public NotifyDAL(string cn)
        {
            db = new dbConnect(cn);
        }

        public List<CanHo> GetCanHoWithTenants()
        {
            List<CanHo> canHoList = new List<CanHo>();
            Dictionary<string, CanHo> canHoMap = new Dictionary<string, CanHo>();

            string sql = "SELECT c.MA_CH, c.MA_CN, c.TEN_CH, c.DIA_CHI, c.LOAI_CH, " +
                         "c.DIEN_TICH, c.GIA_THUE_DAI_HAN, c.GIA_THUE_NGAN_HAN, " +
                         "n.MA_KH, n.TEN_KH, n.SDT, n.CCCD_PASSPORT, n.EMAIL, n.QUOCTICH, n.DIA_CHI AS NTN_DIA_CHI " +
                         "FROM CAN_HO c " +
                         "JOIN HOP_DONG h ON c.MA_CH = h.MA_CH " +
                         "JOIN NGUOI_THUE_NHA n ON h.MA_KH = n.MA_KH " +
                         "WHERE h.NGAY_BAT_DAU <= GETDATE() AND h.NGAY_KET_THUC >= GETDATE()";

            DataTable dt = db.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                string maCanHo = row["MA_CH"].ToString();

                if (!canHoMap.ContainsKey(maCanHo))
                {
                    CanHo canHo = new CanHo
                    {
                        MaCanHo = maCanHo,
                        MaChuNha = row["MA_CN"].ToString(),
                        TenCanHo = row["TEN_CH"].ToString(),
                        DiaChi = row["DIA_CHI"].ToString(),
                        LoaiCanHo = row["LOAI_CH"].ToString(),
                        DienTich = row["DIEN_TICH"] != DBNull.Value ? Convert.ToSingle(row["DIEN_TICH"]) : (float?)null,
                        GiaThueDaiHan = Convert.ToInt32(row["GIA_THUE_DAI_HAN"]),
                        GiaThueNganHan = Convert.ToInt32(row["GIA_THUE_NGAN_HAN"]),
                        NguoiThueNhas = new List<NguoiThueNha>()
                    };
                    canHoMap[maCanHo] = canHo;
                }

                NguoiThueNha tenant = new NguoiThueNha
                {
                    MaKhachHang = row["MA_KH"].ToString(),
                    HoTen = row["TEN_KH"].ToString(),
                    SDT = row["SDT"].ToString(),
                    CCCDPassport = row["CCCD_PASSPORT"].ToString(),
                    Email = row["EMAIL"].ToString(),
                    QuocTich = row["QUOCTICH"].ToString(),
                    DiaChi = row["NTN_DIA_CHI"].ToString()
                };

                canHoMap[maCanHo].NguoiThueNhas.Add(tenant);
            }

            return canHoMap.Values.ToList();
        }

    }
}
