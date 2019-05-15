using DataAccessLayer.Models;
using System.Collections.Generic;


namespace DataAccessLayer
{
   public interface DAL_IGetMyCart
    {
        List<GetCartView> GetCart(int UserId);
    }
}
