using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ChuNhaBUS
    {
        private ChuNhaDAL cn;
        public ChuNhaBUS(string cn)
        {
            this.cn = new ChuNhaDAL(cn);
        }
        public List<ChuNha> GetAllChuNha()
        {
            return cn.GetAllChuNha();
        }
        public int AddChuNha(ChuNha ch)
        {
            return this.cn.AddChuNha(ch);
        }
        public int UpdateChuNha(ChuNha ch)
        {
            return this.cn.UpdateChuNha(ch);
        }
        public int DeleteChuNha(string maChuNha)
        {
            return this.cn.DeleteChuNha(maChuNha);
        }
        public List<ChuNha> GetChuNhaByID(string maChuNha)
        {
            return cn.GetChuNhaByMaChuNha(maChuNha);
        }
    }
}
