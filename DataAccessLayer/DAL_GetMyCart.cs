using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class DAL_GetMyCart :ImageFormat, DAL_IGetMyCart
    {
        public List<GetCartView> GetCart(int UserId)
        {
            using(var db = new sdirecttestdbEntities1())
            {
                List<GetCartView> myCart = new List<GetCartView>();
                var itemCountAndInventoryIds = db.spGetItemCountAndInventoryId_Sk(UserId);
                foreach(var i in itemCountAndInventoryIds)
                {
                    var ProductData = db.spGetMyCart_Sk(i.InventoryId).FirstOrDefault();
                    myCart.Add(new GetCartView()
                    {
                        ItemCount = i.ItemCount,
                        Product = new AddProductView() {
                            Brand = ProductData.Brand,
                            Image = this.ByteArrayToString(ProductData.Image),
                            ProductCategoryId = ProductData.ProductCategoryId,
                            PricePerUnit = ProductData.PricePerUnit,
                            ProductCount = ProductData.ProductCount,
                            ProductName = ProductData.ProductName,
                            Description = ProductData.Description,
                            SellerId = ProductData.SellerId,
                            SellerFullName = db.spGetSellerFullName_Sk(ProductData.SellerId).FirstOrDefault().ToString()
                        }
                    });
                }
                return myCart;

            }
        }
    }
}
