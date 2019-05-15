using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class GetCartView
    {
        public int ItemCount { get; set; }
        public AddProductView Product { get; set; }

    }
}
