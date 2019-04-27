using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public class DAL_PostEmailPw :ImageFormat, DAL_IPostEmailPw
    {
        public UserView Post(EmailPasswordView credentials)
        {
            using(var db = new sdirecttestdbEntities())
            {
                var result = (from obj in db.tblUser_Sk
                              where (obj.Email == credentials.Email)
                              select obj).ToList();

                var user = new UserView();
                int k = 0;

                foreach (var i in result) {

                    var UserTables = db.GetUserDetails_Sk(i.UserId).ToList();

                    foreach(var j in UserTables)
                    {
                        if (k == 0)
                        {
                            user.UserId = j.UserId; 
                            user.FirstName = j.FirstName;
                            user.MiddleName = j.MiddleName;
                            user.LastName = j.LastName;
                            user.Email = j.Email;
                            user.Type1 = j.Type;
                            user.CityName1 = j.CityName;
                            user.StateName1 = j.StateName;
                            user.Mobile = j.Mobile;
                            user.Pincode1 = j.Pincode;
                            user.Address1 = j.Address;
                            user.CountryName1 = j.CountryName;
                            user.Image = this.ByteArrayToString(j.Image);
                        }
                        else
                        {
                            user.Type2 = j.Type;
                            user.CityName2 = j.CityName;
                            user.StateName2 = j.StateName;
                            user.Pincode2 = j.Pincode;
                            user.Address2 = j.Address;
                            user.CountryName2 = j.CountryName;
                        }
                        k++;
                    }
                  
                }
                return user;
            }
        }
    }
}