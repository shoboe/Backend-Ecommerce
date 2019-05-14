using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.Models
{
    public class ChangeSellerStatusModel
    {
        public int SellerId { get; set; }
        public bool Action { get; set; }

    }
}