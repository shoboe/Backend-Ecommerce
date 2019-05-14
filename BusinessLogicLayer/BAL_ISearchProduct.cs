using E_Commerce_ShoebApi.DAL;
using E_Commerce_ShoebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_ShoebApi.BAL
{
    public interface BAL_ISearchProduct
    {
        List<SearchProductView> GetProducts(string productName);

    }
}
