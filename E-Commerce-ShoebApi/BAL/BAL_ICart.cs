﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_ShoebApi.BAL
{
    public interface BAL_ICart
    {
        void BAL_AddToCart(int productId);
    }
}