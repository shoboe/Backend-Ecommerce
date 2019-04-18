using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public class DAL_PostEmailPw : DAL_IPostEmailPw
    {

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public long Pincode { get; set; }
        public string CountryName { get; set; }

        public DAL_PostEmailPw Post(string email, string password)
        {
            using(var db = new sdirecttestdbEntities())
            {
                var result = (from obj in db.tblUser_Sk
                              where (obj.Email == email &&
                                obj.Password == password)
                              select obj);
                foreach (var i in result) {

                    var data = db.GetUserDetails_Sk(i.UserId).ToList();
                    foreach(var j in data)
                    {
                        Console.WriteLine(j);
                    }
                    break;
                }
            }
            return this;
        }
    }
}