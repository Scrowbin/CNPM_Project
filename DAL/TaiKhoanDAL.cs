using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; 
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private dbConnect db;
        public TaiKhoanDAL(string cn)
        {
            db = new dbConnect(cn);
        }

        public int KiemTra(TaiKhoan tk)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@email", tk.Email),
                new SqlParameter("@password", tk.MatKhau)
            };
            return db.ExecuteSQL("spCheckLogin", parameters);
        }
    }
}
