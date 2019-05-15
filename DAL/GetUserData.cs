using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CesusEntityFramework;
using AutoMapper;
using Shared.DTO;
using System.Diagnostics;
using System.Data.Entity;

namespace DAL
{
    public class GetUserData:IUser
    {
        CensusDataContext db = new CensusDataContext();

        static MapperConfiguration config = new MapperConfiguration(newconfig =>
        {
            newconfig.CreateMap<User, UserDTO>().ReverseMap();
            //.ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserID));

        });

        private IMapper mapper = config.CreateMapper();

        public List<UserDTO> GetUserList()
        {
            db.Database.Log = x => Debug.WriteLine(x);
            return mapper.Map<List<UserDTO>>(db.Users.ToList());
        }

        public string CreateUser(UserDTO user)
        {
            db.Database.Log = x => Debug.WriteLine(x);
            var usr = mapper.Map<UserDTO>(db.Users.FirstOrDefault(m => m.email == user.email));
            var usr1 = mapper.Map<UserDTO>(db.Users.FirstOrDefault(m => m.adhaarNumber == user.adhaarNumber));
            if (usr == null && usr1==null)
            {
                try
                {
                    db.Database.Log = x => Debug.WriteLine(x);

                    db.Users.Add(mapper.Map<User>(user));
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                return "User Added";
            }
            else if(usr==null && usr1!=null)
            {
                return "Adhaar";
            }
            else if (usr != null && usr1 == null)
            {
                return "Email";
            }
            else
            {
                return "AdhaarEmail";
            }


        }

        public List<UserDTO> approvedUsers(int id)
        {
            db.Database.Log = x => Debug.WriteLine(x);
            return mapper.Map<List<UserDTO>>(db.Users.Where(m=>m.Status==User.status.Approved));
        }

        public List<UserDTO> pendingUsers(int id)
        {
            db.Database.Log = x => Debug.WriteLine(x);
            return mapper.Map<List<UserDTO>>(db.Users.Where(m => m.Status == User.status.Pending));
        }

        public List<UserDTO> rejectedUsers(int id)
        {
            db.Database.Log = x => Debug.WriteLine(x);
            return mapper.Map<List<UserDTO>>(db.Users.Where(m => m.Status == User.status.Rejected));
        }

        public void PostEditStatus(int id,int value)
        {
            User user = db.Users.Find(id);
            if(value==1)
            {
                user.Status = User.status.Approved;
            }
            if(value==2)
            {
                user.Status = User.status.Rejected;
            }
            db.SaveChanges();
        }
        
        public UserDTO Login(UserDTO user)
        {
                db.Database.Log = x => Debug.WriteLine(x);
                UserDTO loggedInUser = mapper.Map<UserDTO>(db.Users.FirstOrDefault(m => m.email == user.email && m.password == user.password));
                return loggedInUser;
            
        }
    }
}
