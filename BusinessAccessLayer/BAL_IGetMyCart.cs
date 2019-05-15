using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public interface BAL_IGetMyCart
    {
        List<GetCartView> GetMyCart(int userId);
    }
}
