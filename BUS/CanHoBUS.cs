// Nghiệp vụ nhà
using System.Data;
using DAL;
using DOT;
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
    }
}