using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.Models
{
    public class RegisterSellerView
    {
        public int UserId { get; set; }
        public int SellerId { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
    }
}