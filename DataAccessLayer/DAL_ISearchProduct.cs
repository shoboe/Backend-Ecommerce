using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface DAL_ISearchProduct
    {
        List<SearchProductView> GetProducts(string productName);
    }
}
