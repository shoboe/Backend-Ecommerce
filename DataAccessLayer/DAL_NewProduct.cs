using DataAccessLayer.Models;
namespace DataAccessLayer
{
    public class DAL_NewProduct :ImageFormat, DAL_INewProduct
    {
        public void AddProduct(AddProductView newProduct)
        {
             using (var db = new sdirecttestdbEntities1())
            {
                db.spAddProduct_Sk(newProduct.ProductCategoryId,
                    newProduct.ProductName,
                    newProduct.Description,
                    newProduct.Brand,
                    this.ImageToByteArray(newProduct.Image),
                    newProduct.SellerFullName,
                    newProduct.SellerFullName,
                    newProduct.PricePerUnit,
                    newProduct.ProductCount,
                    newProduct.SellerId
                    );
                db.SaveChanges();
            }
            
        }
    }
}