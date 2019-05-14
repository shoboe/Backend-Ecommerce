
using DataAccessLayer.Models;
using System.Collections.Generic;


namespace BusinessAccessLayer
{
    public interface BAL_ISellerRequestAction
    {
        void RegisterSeller(List<RegisterSellerView> decision);
    }
}
