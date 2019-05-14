using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_ShoebApi.DAL
{
    public interface DAL_IGenerateOTP
    {
        bool GenerateOTPviaEmail(string userEmail);
        bool VerifyOtp(string email, int otp);
    }
}
