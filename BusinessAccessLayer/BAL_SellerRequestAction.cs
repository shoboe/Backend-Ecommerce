using System.Collections.Generic;

using DataAccessLayer;
using DataAccessLayer.Models;

namespace BusinessAccessLayer
{
    public class BAL_SellerRequestAction : BAL_ISellerRequestAction
    {
        DAL_ISellerRequestAction DAL_iRegisterSeller;
       public BAL_SellerRequestAction(DAL_ISellerRequestAction DAL_iRegisterSeller)
        {
            DAL_iRegisterSeller = this.DAL_iRegisterSeller;
        }
        public void RegisterSeller(List<RegisterSellerView> decision)
        {
            DAL_iRegisterSeller.RegisterSeller(decision);
        }
    }
}