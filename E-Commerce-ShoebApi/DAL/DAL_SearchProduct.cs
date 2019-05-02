using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi.DAL
{
    public class DAL_SearchProduct :ImageFormat, DAL_ISearchProduct
    {

        public List<SearchProductView> GetProducts(string productName)
        {
            List<SearchProductView> products = new List<SearchProductView>();
            using (var db = new sdirecttestdbEntities1())
            {
                products.AddRange((from x in db.tblProducts_Sk
                                      where (x.ProductName == productName)
                                      select new SearchProductView()
                                      {
                                          ProductName = x.ProductName,
                                          ProductId = x.ProductId,
                                          ProductCategoryId = x.ProductCategoryId,
                                          Description = x.Description,
                                          Brand = x.Brand,
                                          Image = this.ByteArrayToString(x.Image)
                                      }
                                     ).ToList());

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
                //tblPaymentMethod_Sk newMethod = new tblPaymentMethod_Sk()
                //{
                //    BankId = 2,
                //    Name = "Debit Card",
                //    IsActive = true,
                //    IsCreatedBy = "Shoeb",
                //    IsUpdatedBy = "Shoeb",
                //    IsCreatedOn = DateTime.Now,
                //    IsUpdatedOn = DateTime.Now,
                //    IsDeleted = false

                //};
                //db.tblPaymentMethod_Sk.Add(newMethod);
                //db.SaveChanges();

                //tblBorrowMoney_Sk obj = new tblBorrowMoney_Sk()
                //{
                //    BankNameUserId = 1,
                //    MoneyBorrowed = 0,
                //    Password = "ABC111",
                //    IsActive = true,
                //    IsCreatedBy = "Shoeb",
                //    IsUpdatedBy = "Shoeb",
                //    IsCreatedOn = DateTime.Now,
                //    IsUpdatedOn = DateTime.Now,
                //    IsDeleted = false

                //};
                //db.tblBorrowMoney_Sk.Add(obj);
                //db.SaveChanges();

                //user = db.tblUser_Sk.Find(2);
                //var serializer = new JavaScriptSerializer();
                //string utfString = Encoding.UTF8.GetString(user.Image, 0, user.Image.Length);
                ////var serializedResult = serializer.Serialize(user.Image);
                //var base64 = Convert.ToBase64String(user.Image);


            }
            //no need as it is directly giving us the required output
            // var base64 = Convert.ToBase64String(getProducts[0].Image);
            return products;
        }
    }
}