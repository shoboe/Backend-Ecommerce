using DataAccessLayer.Models;

namespace BusinessAccessLayer
{
    public interface BAL_IRegisterUser
    {
        void Register(RegisterUserView user);
    }
}
