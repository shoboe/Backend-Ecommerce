using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.DAL
{
    public class AddProductView
    {
        [Required]
        public int ProductCategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string SellerName { get; set; }
        [Required]
        public string UpdaterName { get; set; }
        [Required]
        public int PricePerUnit { get; set; }
        [Required]
        public int ProductCount { get; set; }
        [Required]
        public int SellerId { get; set; }
    }
}