using E_Commerce_ShoebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_ShoebApi.DAL
{
    public interface DAL_IRegisterUser
    {
        void Register(RegisterUserView user);
    }
}
