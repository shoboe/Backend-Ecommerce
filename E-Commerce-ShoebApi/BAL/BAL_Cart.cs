using E_Commerce_ShoebApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ShoebApi.BAL
{
    public class BAL_Cart : BAL_ICart
    {
        DAL_ICart DAL_iCart;
        public BAL_Cart(DAL_ICart DAL_iCart)
        {
            this.DAL_iCart = DAL_iCart;
        }

        void BAL_ICart.BAL_AddToCart(int productId)
        {
            DAL_iCart.AddToCart(productId);
        }
    }
}