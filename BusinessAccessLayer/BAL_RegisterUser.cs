
using DataAccessLayer;
using DataAccessLayer.Models;

namespace BusinessAccessLayer
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