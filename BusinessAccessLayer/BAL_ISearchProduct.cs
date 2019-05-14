using System.Collections.Generic;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public interface BAL_ISearchProduct
    {
        List<SearchProductView> GetProducts(string productName);

    }
}
