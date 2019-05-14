
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public interface DAL_INewProduct
    {
        void AddProduct(AddProductView newProduct);
    }
}
