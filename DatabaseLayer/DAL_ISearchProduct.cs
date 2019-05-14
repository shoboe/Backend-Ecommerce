using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public interface DAL_ISearchProduct
    {
        List<SearchProductView> GetProducts(string productName);
    }
}
