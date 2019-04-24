using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.Models
{
    public class RegisterUserView
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public long Mobile { get; set; }
        public string CityName1 { get; set; }
        public long Pincode1 { get; set; }
        public string Type1 { get; set; }
        public string Address1 { get; set; }
        public string BusinessType { get; set; }
        public string BankName { get; set; }
        public bool IsSeller { get; set; }
        public long AccountNumber { get; set; }
        public string CityName2 { get; set; }
        public long Pincode2 { get; set; }
        public string Type2 { get; set; }
        public string Address2 { get; set; }
        public int OTP { get; set; }

    }
}