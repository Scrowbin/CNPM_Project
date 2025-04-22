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
        private dbConnect db = new dbConnect();

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
    }
}
