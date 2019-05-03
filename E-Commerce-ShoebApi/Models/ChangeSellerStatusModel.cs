using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.Models
{
    public class ChangeSellerStatusModel
    {
        public int SellerId { get; set; }
        public bool Action { get; set; }

    }
}