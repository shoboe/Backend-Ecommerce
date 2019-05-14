
using DataAccessLayer.Models;
namespace BusinessAccessLayer
{
    public interface BAL_IPostEmailPw
    {
        UserView Post(EmailPasswordView credentials);
    }
}
