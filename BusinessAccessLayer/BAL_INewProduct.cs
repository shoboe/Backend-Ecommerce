﻿using DataAccessLayer.Models;

namespace BusinessAccessLayer
{
    public interface BAL_INewProduct
    {
        void AddProduct(AddProductView newProduct);
    }
}
