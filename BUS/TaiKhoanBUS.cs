using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL tkDAL;
        public TaiKhoanBUS(string cn)
        {
            tkDAL = new TaiKhoanDAL(cn);
        }
        public int KiemTra(TaiKhoan tk)
        {
            return tkDAL.KiemTra(tk);
        }
    }
}
