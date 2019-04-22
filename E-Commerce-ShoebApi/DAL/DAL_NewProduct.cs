using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public class DAL_NewProduct :ImageFormat, DAL_INewProduct
    {
        public void AddProduct(AddProductView newProduct)
        {
             using (var db = new sdirecttestdbEntities())
            {
                db.AddProduct_Sk(newProduct.ProductCategoryId,
                    newProduct.ProductName,
                    newProduct.Description,
                    newProduct.Brand,
                    this.ImageToByteArray(newProduct.Image),
                    newProduct.SellerName,
                    newProduct.UpdaterName,
                    newProduct.PricePerUnit,
                    newProduct.ProductCount,
                    newProduct.SellerId
                    );
                db.SaveChanges();
            }
            
        }
    }
}