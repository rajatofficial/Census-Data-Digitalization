using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DTO;

namespace BAL
{
    public interface IUserService
    {
        List<UserDTO> ServiceGetUserList();
        string ServiceCreateUser(UserDTO user);
        List<UserDTO> serviceApprovedUsers(int id);
        List<UserDTO> serviceRejectedUsers(int id);
        List<UserDTO> servicePendingUsers(int id);
        void EditStatus(int id, int value);
        UserDTO LoginService(UserDTO user);

    }
}
