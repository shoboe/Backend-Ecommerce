using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Linq;
using System.Net.Mail;
namespace DataAccessLayer.Models
{
    public class GenerateOTP : DAL_IGenerateOTP
    {
        public bool GenerateOTPviaEmail(string userEmail)
        {
            using(var db = new sdirecttestdbEntities1())
            {
                var result = (from i in db.tblUser_Sk
                              where i.Email == userEmail && i.IsActive == true
                              select i).Any();
                if (result)
                    return false;
                else
                {
                    var random = new Random();
                    var num = random.Next(10000, 54999);

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
                    msg.To.Add(new MailAddress(userEmail));

                    msg.Subject = "OTP For Registeration on EzBuy";
                    msg.IsBodyHtml = true;
                    msg.Body = "Your OTP is: " + num.ToString();

                    try
                    {
                        client.Send(msg);
                        db.spAddOtp_Sk(userEmail, num);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            
        }

        public bool VerifyOtp(string email, int otp)
        {
            using(var db = new sdirecttestdbEntities1())
            {
                var result = (from x in db.tblOtp_Sk
                              where x.Email == email && x.OTP == otp && x.IsActive == true
                              select x).FirstOrDefault();
                if (result != null)
                {
                    db.spDeleteOtp_Sk(result.OtpId);
                    return true;
                }
               
            }
            return false;
        }
    }
}