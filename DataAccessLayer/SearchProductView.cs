using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{
    public class SearchProductView
    {
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }
        public int InventoryId { get; set; }
        public int PricePerUnit { get; set; }
        public int ProductCount { get; set; }
        public int SellerId { get; set; }
        public string SellerFirstName { get; set; }
        public string SellerMiddleName { get; set; }
        public string SellerLastName { get; set; }
    }
}