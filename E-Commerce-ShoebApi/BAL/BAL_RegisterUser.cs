using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.DAL;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.BAL
{
    public class BAL_RegisterUser : BAL_IRegisterUser
    {
        DAL_IRegisterUser DAL_iRegisterUser;
        public BAL_RegisterUser(DAL_IRegisterUser DAL_iRegisterUser)
        {
            this.DAL_iRegisterUser = DAL_iRegisterUser;
        }
        public void Register(RegisterUserView user)
        {
            DAL_iRegisterUser.Register(user);
        }
    }
}