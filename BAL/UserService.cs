using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Shared.DTO;

namespace BAL
{
    public class UserService:IUserService
    {
        IUser db1 = new GetUserData();

        public List<UserDTO> ServiceGetUserList()
        {
            List<UserDTO> userlist = db1.GetUserList();
            return userlist;
        }

        public string ServiceCreateUser(UserDTO user)
        {
            return db1.CreateUser(user);
        }

        public List<UserDTO> serviceApprovedUsers(int id)
        {
            return db1.approvedUsers(id);
        }

        public List<UserDTO> serviceRejectedUsers(int id)
        {
            return db1.rejectedUsers(id);
        }

        public List<UserDTO> servicePendingUsers(int id)
        {
            return db1.pendingUsers(id);
        }

        public void EditStatus(int id,int value)
        {
            db1.PostEditStatus(id, value);
        }

        public UserDTO LoginService(UserDTO user)
        {
            return db1.Login(user);
        }

       
    }
}
