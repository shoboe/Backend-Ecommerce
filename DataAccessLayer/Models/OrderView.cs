using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class OrderView
    {
        public int UserId { get; set; }
        public int ProductCount { get; set; }
        public int ProductId { get; set; }
    }
}
