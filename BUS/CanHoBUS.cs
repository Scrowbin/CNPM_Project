using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class CanHoBUS
    {
        private CanHoDAL ch;
        public CanHoBUS(string cn)
        {
            ch = new CanHoDAL(cn);
        }
        public List<CanHo> GetAllCanHo()
        {
            return ch.GetAllCanHo();
        }
        public int AddCanHo(CanHo ch)
        {
            return this.ch.AddCanHo(ch);
        }
        public int UpdateCanHo(CanHo ch)
        {
            return this.ch.UpdateCanHo(ch);
        }
        public int DeleteCanHo(string maCanHo)
        {
            return this.ch.DeleteCanHo(maCanHo);
        }
        public CanHo GetCanHoByID(string maChuNha)
        {
            return ch.GetCanHoByMaChuNha(maChuNha);
        }
    }
}