using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DTO;

namespace DAL
{
    public interface IUser
    {
         List<UserDTO> GetUserList();
         string CreateUser(UserDTO user);
         List<UserDTO> approvedUsers(int id);
         List<UserDTO> pendingUsers(int id);
         List<UserDTO> rejectedUsers(int id);
         void PostEditStatus(int id, int value);
         UserDTO Login(UserDTO user);
    }
}
