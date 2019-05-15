using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Shared.DTO;

namespace BAL
{
    public class HouseService:IHouseService
    {
        IHouse db1 = new HouseData();
        public int ServicePostHouse(HouseDTO house)
        {
            return(db1.PostHouse(house));
        }

        public bool ServiceFindCensusNumber(int id)
        {
           return db1.FindCensusNumber(id);
        }

        public IEnumerable<object> HGraphService()
        {
            return db1.GraphData();
        }
    }
}
