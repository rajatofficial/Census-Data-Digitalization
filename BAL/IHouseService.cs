using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DTO;

namespace BAL
{
    public interface IHouseService
    {
         int ServicePostHouse(HouseDTO house);
         bool ServiceFindCensusNumber(int id);
        IEnumerable<object> HGraphService();
        }
}
