using DataAccessLayer.Models;
namespace DataAccessLayer
{
    public interface DAL_IRegisterUser
    {
        void Register(RegisterUserView user);
    }
}
