using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.Models
{
    public class UserView
    {
        public Nullable<bool> IsSeller { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Type1 { get; set; }
        public string Address1 { get; set; }
        public string CityName1 { get; set; }
        public string StateName1 { get; set; }
        public long Pincode1 { get; set; }
        public string CountryName1 { get; set; }
        public string Type2 { get; set; }
        public string Address2 { get; set; }
        public string CityName2 { get; set; }
        public string StateName2 { get; set; }
        public long Pincode2 { get; set; }
        public string CountryName2 { get; set; }
        public string Image { get; set; }

    }
}