using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DTO;

namespace DAL
{
    public interface IHouse
    {
        int PostHouse(HouseDTO house);
         bool FindCensusNumber(int id);
        IEnumerable<object> GraphData();
        }

}
