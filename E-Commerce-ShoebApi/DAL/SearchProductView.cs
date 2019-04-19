using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.DAL
{
    public class SearchProductView
    {
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}