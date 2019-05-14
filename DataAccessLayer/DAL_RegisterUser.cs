using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class DAL_RegisterUser : ImageFormat, DAL_IRegisterUser
    {
        public void Register(RegisterUserView user)
        {
            using (var db = new sdirecttestdbEntities1())
            {
                db.spRegisterUser_Sk(
                    user.FirstName,
                    user.MiddleName,
                    user.LastName,
                    user.Email,
                    user.Password,
                    this.ImageToByteArray(user.Image),
                    user.Mobile,
                    user.CityName1,
                    user.Pincode1,
                    user.Type1,
                    user.Address1,
                    user.Type2,
                    user.CityName2,
                    user.Pincode2,
                    user.Address2,
                    user.IsSeller,
                    user.BusinessType,
                    user.BankName,
                    user.AccountNumber
                    );
                db.SaveChanges();
            }
        }
    }
}