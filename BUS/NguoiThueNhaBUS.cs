using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class NguoiThueNhaBUS
    {
        private NguoiThueNhaDAL ntn;
        public NguoiThueNhaBUS(string cn)
        {
            ntn = new NguoiThueNhaDAL(cn);
        }
        public List<NguoiThueNha> GetAllNguoiThueNha()
        {
            return ntn.GetAllNguoiThueNha();
        }
        public int AddNguoiThueNha(NguoiThueNha ch)
        {
            return ntn.AddNguoiThueNha(ch);
        }
        public int UpdateNguoiThueNha(NguoiThueNha ch)
        {
            return ntn.UpdateNguoiThueNha(ch);
        }
        public int DeleteNguoiThueNha(string maKhachHang)
        {
            return ntn.DeleteNguoiThueNha(maKhachHang);
        }
        public NguoiThueNha GetNguoiThueNhaByMaKhachHang(string maKhachHang)
        {
            return ntn.GetNguoiThueNhaByMaKhachHang(maKhachHang);
        }
    }
}
