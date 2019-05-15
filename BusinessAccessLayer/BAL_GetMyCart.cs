using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;

namespace BusinessAccessLayer
{
    public class BAL_GetMyCart : BAL_IGetMyCart
    {
        DAL_IGetMyCart DAL_iGetMyCart;
        public BAL_GetMyCart(DAL_IGetMyCart DAL_iGetMyCart)
        {
            this.DAL_iGetMyCart = DAL_iGetMyCart;
        }
        public List<GetCartView> GetMyCart(int userId)
        {
            return this.DAL_iGetMyCart.GetCart(userId);
        }
    }
}
