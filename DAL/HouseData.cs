using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CesusEntityFramework;
using Shared.DTO;

namespace DAL
{
    public class HouseData: IHouse
    {
        CensusDataContext db = new CensusDataContext();

        static MapperConfiguration config = new MapperConfiguration(newconfig =>
        {
            newconfig.CreateMap<User, UserDTO>().ReverseMap();
            //.ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserID));

        });

        private IMapper mapper = config.CreateMapper();

        public int PostHouse(HouseDTO house)
        {
            House newHouse = mapper.Map<House>(house);
            db.Houses.Add(newHouse);
            db.SaveChanges();
            return (newHouse.id);
        }

        public bool FindCensusNumber(int id)
        {
            db.Database.Log = x => Debug.WriteLine(x);
            var usr = mapper.Map<HouseDTO>(db.Houses.Find(id));
            if (usr == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public IEnumerable<object> GraphData()
        {
            return db.Houses.GroupBy(m => m.state).Select(g => new { State = g.Key, Population = g.Count() });
        }
    }

    }

