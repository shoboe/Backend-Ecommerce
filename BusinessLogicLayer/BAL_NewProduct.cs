using E_Commerce_ShoebApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.BAL
{
    public class BAL_NewProduct : BAL_INewProduct
    {
        DAL_INewProduct DAL_iNewProduct;
        public BAL_NewProduct(DAL_INewProduct DAL_iNewProduct)
        {
            this.DAL_iNewProduct = DAL_iNewProduct;
        }
        public void AddProduct(AddProductView newProduct)
        {
            DAL_iNewProduct.AddProduct(newProduct);
        }
    }
}