using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public interface DAL_ItblProducts
    {
        List<DAL_tblProducts> GetProducts(string productName);
    }
}
