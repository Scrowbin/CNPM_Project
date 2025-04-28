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
        private dbConnect db = new dbConnect();

        public List<ChuNha> GetAllChuNha()
        {
            List<ChuNha> list = new List<ChuNha>();
            string sql = "SELECT * FROM CHU_NHA";
            DataTable dt = db.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                ChuNha ch = new ChuNha
                {
                    MaChuNha = row["MA_CHU_NHA"].ToString(),
                    HoTen = row["HO_TEN"].ToString(),
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
