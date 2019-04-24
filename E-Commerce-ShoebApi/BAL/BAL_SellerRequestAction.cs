using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.DAL;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.BAL
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