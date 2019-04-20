using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public class DAL_RegisterUser : ImageFormat, DAL_IRegisterUser
    {
        public void Register(RegisterUserView user)
        {
            using (var db = new sdirecttestdbEntities())
            {
                db.RegisterUser_Sk(
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