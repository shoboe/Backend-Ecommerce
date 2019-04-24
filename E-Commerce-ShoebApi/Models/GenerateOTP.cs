using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using E_Commerce_ShoebApi.DAL;
namespace E_Commerce_ShoebApi.Models
{
    public class GenerateOTP : DAL_IGenerateOTP
    {
        public void GenerateOTPviaEmail(string userEmail)
        {
                var random = new Random();
                var num = random.Next(10000,54999);

                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                // setup Smtp authentication
                System.Net.NetworkCredential credentials =
                    new System.Net.NetworkCredential("rahulpatel.rbl.p@gmail.com", "9044470244");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;
                //can be obtained from your model
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("rahulpatel.rbl.p@gmail.com");
                msg.To.Add(new MailAddress("shoeb96k@gmail.com"));

                msg.Subject = "OTP For Registeration on EzBuy";
                msg.IsBodyHtml = true;
                msg.Body = "Your OTP is: "+num.ToString();
                
                using(var db = new sdirecttestdbEntities()) {
                    db.AddOtp_Sk(userEmail, num);
                }
            
        }

        public bool VerifyOtp(string email, int otp)
        {
            using(var db = new sdirecttestdbEntities())
            {
                var result = (from x in db.tblOtp_Sk
                              where x.Email == email && x.OTP == otp && x.IsActive == true
                              select x
                              ).ToList();
                if (result.Count == 1)
                    return true;
                else return false;
            }
        }
    }
}