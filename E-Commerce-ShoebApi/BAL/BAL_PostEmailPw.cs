using E_Commerce_ShoebApi.DAL;

namespace E_Commerce_ShoebApi.BAL
{
    public class BAL_PostEmailPw:BAL_IPostEmailPw
    {
        DAL_IPostEmailPw DAL_IPostEmailPw;
        public BAL_PostEmailPw(DAL_IPostEmailPw DAL_IPostEmailPw)
        {
            this.DAL_IPostEmailPw = DAL_IPostEmailPw;
        }
        public DAL_PostEmailPw Post(string email, string password)
        {
            return DAL_IPostEmailPw.Post(email, password);
        }

    }
}