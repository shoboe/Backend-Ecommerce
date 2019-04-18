using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public class DAL_tblProducts : DAL_ItblProducts
    {
        public int ProductId { get; set;  }
        public int ProductCategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public byte[] Image { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public List<DAL_tblProducts> GetProducts(string productName)
        {
            List<DAL_tblProducts> getProducts = new List<DAL_tblProducts>();
            using (var db = new sdirecttestdbEntities())
            {
                //getProducts.AddRange((from obj in db.tblProducts_Sk
                //                      where (obj.ProductName == productName)
                //                      select new DAL_tblProducts()
                //                      {
                //                          ProductName = obj.ProductName,
                //                          ProductId = obj.ProductId,
                //                          ProductCategoryId = obj.ProductCategoryId,
                //                          Description = obj.Description,
                //                          Brand = obj.Brand,
                //                          Image = obj.Image,
                //                      }
                //                     ).ToList());
                //byte[] array = Encoding.ASCII.GetBytes(input);

                //tblProducts_Sk newProduct = new tblProducts_Sk()
                //{
                //    ProductCategoryId = 4,
                //    ProductName = "Gate",
                //    Description = "Prepare with the best",
                //    Brand = "Pearson",
                //    IsActive = true,
                //    IsCreatedBy = "Shoeb",
                //    IsUpdatedBy = "Shoeb",
                //    IsCreatedOn = DateTime.Now,
                //    IsUpdatedOn = DateTime.Now,
                //    IsDeleted = false,
                //    Image = array
                //};
                //db.tblProducts_Sk.Add(newProduct);
                //db.SaveChanges();

                //to update something
                //tblProducts_Sk updateProduct = db.tblProducts_Sk.Find(6);
                //updateProduct.ProductCategoryId = 5;
                //db.Entry(updateProduct).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();


                //tblBankNameUser
                //tblBankNameUser_Sk newUser = new tblBankNameUser_Sk(){
                //BankId = 2,
                //Username = "pqrhere",
                //Password = "pqrhere",
                //Mobile = 1234567890,
                //AccountNumber = 882329,
                //Balance = 12000,
                //  IsActive = true,
                //    IsCreatedBy = "Shoeb",
                //    IsUpdatedBy = "Shoeb",
                //    IsCreatedOn = DateTime.Now,
                //    IsUpdatedOn = DateTime.Now,
                //    IsDeleted = false
                //};
                //db.tblBankNameUser_Sk.Add(newUser);
                //db.SaveChanges();

                //tblRole_Sk newRole = new tblRole_Sk();
                //newRole.RoleName = "User";
                //newRole.IsCreatedBy = "Shoeb";
                //newRole.IsUpdatedBy = "Shoeb";
                //newRole.IsCreatedOn = DateTime.Now;
                //newRole.IsUpdatedOn = DateTime.Now;
                //db.tblRole_Sk.Add(newRole);
                //db.SaveChanges();

                //tblUser_Sk user = new tblUser_Sk();
                //{
                //    RoleId = 4,
                //    FirstName = "Shoeb",
                //    MiddleName = "",
                //    LastName = "Khan",
                //    Email = "Shoeb96k@gmail.com",
                //    Password = "admin@123",
                //    Mobile = "8006356362",
                //    IsCreatedBy = "Shoeb",
                //    IsUpdatedBy = "Shoeb",
                //    Image = array,
                //    IsCreatedOn = DateTime.Now,
                //    IsUpdatedOn = DateTime.Now

                //};
                //db.tblUser_Sk.Add(user);
                //db.SaveChanges();

                //PtblPaymentMethod_Sk add details
                tblPaymentMethod_Sk newMethod = new tblPaymentMethod_Sk()
                {
                    BankId = 1,
                    Name = "Net Banking",
                    IsActive = true,
                    IsCreatedBy = "Shoeb",
                    IsUpdatedBy = "Shoeb",
                    IsCreatedOn = DateTime.Now,
                    IsUpdatedOn = DateTime.Now,
                    IsDeleted = false

                };
                db.tblPaymentMethod_Sk.Add(newMethod);
                db.SaveChanges();

                //user = db.tblUser_Sk.Find(2);
                //var serializer = new JavaScriptSerializer();
                //string utfString = Encoding.UTF8.GetString(user.Image, 0, user.Image.Length);
                ////var serializedResult = serializer.Serialize(user.Image);
                //var base64 = Convert.ToBase64String(user.Image);


            }
            //no need as it is directly giving us the required output
            // var base64 = Convert.ToBase64String(getProducts[0].Image);
            return getProducts;
        }
    }
}