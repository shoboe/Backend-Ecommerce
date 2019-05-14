using DataAccessLayer;
using DataAccessLayer.Models;


namespace BusinessAccessLayer
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