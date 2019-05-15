using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CesusEntityFramework;
using Shared.DTO;

namespace DAL
{
    public class PopulationData: IPopulation
    {
        CensusDataContext db = new CensusDataContext();

        static MapperConfiguration config = new MapperConfiguration(newconfig =>
        {
            newconfig.CreateMap<User, UserDTO>().ReverseMap();

        });

        private IMapper mapper = config.CreateMapper();
        public void PostPopulation(PopulationDTO ppl)
        {
            db.Population.Add(mapper.Map<Population>(ppl));
            db.SaveChanges();
        }


    }
}
