using E_Commerce_ShoebApi.Models;
using DataAccessLayer;

namespace BusinessAccessLayer
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