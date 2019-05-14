using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Script.Serialization;
using E_Commerce_ShoebApi.BAL;
using E_Commerce_ShoebApi.DAL;
using E_Commerce_ShoebApi.Models;
using Newtonsoft.Json;

namespace E_Commerce_ShoebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ViewController : ApiController
    {
        BAL_ISearchProduct BAL_itblProducts;
        BAL_IPostEmailPw BAL_iPostEmailPw;
        BAL_INewProduct BAL_iNewProduct;
        BAL_IAddBankAccount BAL_iAddBankAccount;
        BAL_IRegisterUser BAL_iRegisterUser;
        DAL_IGenerateOTP DAL_iGenererate;
        DAL_IGetAllUsers DAL_iGetAllUsers;
        public ViewController(BAL_ISearchProduct BAL_itblProducts, BAL_IPostEmailPw BAL_iPostEmailPw,
            BAL_INewProduct BAL_iNewProduct, BAL_IAddBankAccount BAL_iAddBankAccount,
             BAL_IRegisterUser BAL_iRegisterUser, DAL_IGenerateOTP DAL_iGenererate,
              DAL_IGetAllUsers DAL_iGetAllUsers)
        {
            this.BAL_itblProducts = BAL_itblProducts;
            this.BAL_iPostEmailPw = BAL_iPostEmailPw;
            this.BAL_iNewProduct = BAL_iNewProduct;
            this.BAL_iAddBankAccount = BAL_iAddBankAccount;
            this.BAL_iRegisterUser = BAL_iRegisterUser;
            this.DAL_iGenererate = DAL_iGenererate;
            this.DAL_iGetAllUsers = DAL_iGetAllUsers;
        }

        [HttpGet]
        [Route("api/view/{GetProducts}")]
        public IHttpActionResult GetProducts(string productName)
        {
            return Json(BAL_itblProducts.GetProducts(productName));
        }
        //// POST api/values
        [Authorize]
        [HttpPost] 
        [Route("api/view/PostCredentials")]
        public IHttpActionResult PostCredentials(EmailPasswordView credentials)
        {
            if (ModelState.IsValid)
            {
                return Json(BAL_iPostEmailPw.Post(credentials));
            }
            return Content(HttpStatusCode.BadRequest, "Request Failed");
        }

        [Authorize]
        [HttpPost]
        [Route("api/view/RegisterNewProduct")]
        public IHttpActionResult RegisterNewProduct([FromBody]AddProductView newProduct)
        {
            if (ModelState.IsValid)
             {
                if (CheckIfSellerVerified.VerifySeller(newProduct.SellerId))
                {
                    BAL_iNewProduct.AddProduct(newProduct);
                    Content(HttpStatusCode.OK, "Added");
                }
                return Content(HttpStatusCode.OK, "Not Authorized To Sell");
            }
            return Content(HttpStatusCode.BadRequest, "Request Failed");
         }

        [HttpPost]
        [Route("api/view/GenerateOtp")]
        public IHttpActionResult GenerateOtp([FromBody]EmailView email)
        {
            //return DAL_iGenererate.GenerateOTPviaEmail(email.Email);
            if (DAL_iGenererate.GenerateOTPviaEmail(email.Email))
                return Content(HttpStatusCode.OK, "Check Email For OTP Verification");
            else
                return Content(HttpStatusCode.BadRequest, "Email Already Taken");
        }


        [HttpPost]
        [Route("api/view/RegisterNewUser")]
        public IHttpActionResult RegisterNewUser(RegisterUserView user)
        {
            if (ModelState.IsValid)
            {
                if (DAL_iGenererate.VerifyOtp(user.Email, user.OTP))
                {
                        
                    BAL_iRegisterUser.Register(user);
                    return Content(HttpStatusCode.OK, "Thank You! Please Login from HomePage.");
                }
            }
            return Content(HttpStatusCode.BadRequest, "Invalid OTP");
        }
        [Authorize]
        [HttpGet]
        [Route("api/view/GetSellerRequests")]
        public IHttpActionResult GetSellerRequests(int UserId)
        {
            using(var db = new sdirecttestdbEntities1())
            {
                var IsAdmin = (from x in db.tblUser_Sk
                               where x.UserId == UserId && x.RoleId == 1
                               select x).FirstOrDefault();
                if(IsAdmin!=null)
                    return Json(db.spSellerRequests_Sk().ToList());
                else
                    return Content(HttpStatusCode.BadRequest, "Not Authorized");
            }
        }

        //For Demo Usage:
        [Authorize]
        [HttpPost]
        [Route("api/view/ChangeSellerStatus")]
        public IHttpActionResult ChangeSellerStatus(List<ChangeSellerStatusModel> statusUpdate)
        {
            if (statusUpdate.Count != 0)
            {
                using (var db = new sdirecttestdbEntities1())
                {

                    foreach (var i in statusUpdate)
                        db.spChangeSellerStatus_Sk(i.SellerId, i.Action);
                }
                return Content(HttpStatusCode.OK, "Done");
            }
            else
                return Content(HttpStatusCode.BadRequest, "Nothing To Update");
        }
        [Authorize]
        [HttpGet]
        [Route("api/view/GetAllUsers")]
        public IHttpActionResult GetAllUsers(int UserId)
        {
        
           using (var db = new sdirecttestdbEntities1())
            {
                var IsAdmin = (from x in db.tblUser_Sk
                               where x.UserId == UserId && x.RoleId == 1
                               select x).FirstOrDefault();
                if (IsAdmin != null)
                    return Json(this.DAL_iGetAllUsers.GetAllUsers());

                return Content(HttpStatusCode.BadRequest, "Not Authorized");

            }

        }


        //[HttpDelete]
        //[Route("api/values/Delete/{id}")]
        //public IHttpActionResult Delete(int id)
        //{
        //    if (myIBusinessAL.Delete(id))
        //        return Ok();
        //    else
        //        return Content(HttpStatusCode.BadRequest, "Couldn't delete");
        //}
    }
}
