using System.Collections.Generic;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class BAL_SearchProduct : BAL_ISearchProduct
    {
        DAL_ISearchProduct DAL_itblProductsL;
        public BAL_SearchProduct(DAL_ISearchProduct DAL_itblProductsL)
        {
            this.DAL_itblProductsL = DAL_itblProductsL;
        }
        public List<SearchProductView> GetProducts(string productName)
        {
            return DAL_itblProductsL.GetProducts(productName);
        }
    }
}