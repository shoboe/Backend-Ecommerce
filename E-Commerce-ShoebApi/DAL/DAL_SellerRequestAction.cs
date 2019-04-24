﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public class DAL_SellerRequestAction : DAL_ISellerRequestAction
    {
        public void RegisterSeller(List<RegisterSellerView> decision)
        {
            using (var db = new sdirecttestdbEntities())
            {
                foreach (var i in decision)
                {
                    db.ChangeSellerStatus_Sk(i.SellerId, i.IsActive);
                }
            }
        }
    }
}