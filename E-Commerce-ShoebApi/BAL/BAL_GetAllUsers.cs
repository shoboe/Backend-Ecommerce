using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.DAL;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.BAL
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