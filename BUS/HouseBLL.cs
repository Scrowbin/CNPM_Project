// Nghiệp vụ nhà
using DAL;

namespace BUS
{
    public class HouseBLL
    {
        private readonly HouseDAL houseDAL;
        public HouseBLL(string cn)
        {
            houseDAL = new HouseDAL(cn);
        }
        public List<Home> GetHouse()
        {
            return houseDAL.GetALlHouses();
        }
    }
}