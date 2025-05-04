using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class NotifyBUS
    {
        private NotifyDAL NotifyDAL;
        public NotifyBUS(string db) { NotifyDAL = new NotifyDAL(db); }
        public List<CanHo> GetCanHoWithTenants()
        {
            return NotifyDAL.GetCanHoWithTenants();
        }
    }
}
