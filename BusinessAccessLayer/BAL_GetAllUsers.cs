
using DataAccessLayer;
using DataAccessLayer.Models;
using System.Collections.Generic;


namespace BusinessAccessLayer
{
    public class BAL_GetAllUsers : BAL_IGetAllUsers
    {
        DAL_IGetAllUsers DAL_iGetAllUsers;
        public BAL_GetAllUsers(DAL_IGetAllUsers DAL_iGetAllUsers)
        {
            this.DAL_iGetAllUsers = DAL_iGetAllUsers;
        }

        public List<GetAllUsersModel> GetAllUsers()
        {
            return this.DAL_iGetAllUsers.GetAllUsers();
        }
    }
}