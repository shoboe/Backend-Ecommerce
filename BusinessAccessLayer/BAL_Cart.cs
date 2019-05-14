using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class BAL_Cart : BAL_ICart
    {
        DAL_ICart DAL_iCart;
        public BAL_Cart(DAL_ICart DAL_iCart)
        {
            this.DAL_iCart = DAL_iCart;
            //laptopTestGit
            //this is so fun
        }

        void BAL_ICart.BAL_AddToCart(int productId)
        {
            DAL_iCart.AddToCart(productId);
        }
    }
}