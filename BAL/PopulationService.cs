using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Shared.DTO;

namespace BAL
{
    public class PopulationService: IPopulationService
    {
        IPopulation db1 = new PopulationData();
     
        public void ServicePostPopulation(PopulationDTO ppl)
        {
            db1.PostPopulation(ppl);
        }
    }
}
