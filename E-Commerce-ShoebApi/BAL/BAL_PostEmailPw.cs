using E_Commerce_ShoebApi.DAL;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.BAL
{
    public class BAL_PostEmailPw:BAL_IPostEmailPw
    {
        DAL_IPostEmailPw DAL_IPostEmailPw;
        public BAL_PostEmailPw(DAL_IPostEmailPw DAL_IPostEmailPw)
        {
            this.DAL_IPostEmailPw = DAL_IPostEmailPw;
        }
        public UserView Post(EmailPasswordView credentials)
        {
            return DAL_IPostEmailPw.Post(credentials);
        }

    }
}