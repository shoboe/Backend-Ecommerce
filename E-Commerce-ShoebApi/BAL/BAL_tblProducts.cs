using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.DAL;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.BAL
{
    public class BAL_tblProducts : BAL_ItblProducts
    {
        DAL_ItblProducts DAL_itblProductsL;
        public BAL_tblProducts(DAL_ItblProducts DAL_itblProductsL)
        {
            this.DAL_itblProductsL = DAL_itblProductsL;
        }
        public List<DAL_tblProducts> GetProducts(string productName)
        {
            return DAL_itblProductsL.GetProducts(productName);
        }
    }
}