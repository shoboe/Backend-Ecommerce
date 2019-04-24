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
        public ViewController(BAL_ISearchProduct BAL_itblProducts, BAL_IPostEmailPw BAL_iPostEmailPw,
            BAL_INewProduct BAL_iNewProduct, BAL_IAddBankAccount BAL_iAddBankAccount,
             BAL_IRegisterUser BAL_iRegisterUser, DAL_IGenerateOTP DAL_iGenererate)
        {
            this.BAL_itblProducts = BAL_itblProducts;
            this.BAL_iPostEmailPw = BAL_iPostEmailPw;
            this.BAL_iNewProduct = BAL_iNewProduct;
            this.BAL_iAddBankAccount = BAL_iAddBankAccount;
            this.BAL_iRegisterUser = BAL_iRegisterUser;
            this.DAL_iGenererate = DAL_iGenererate;
        }

        [HttpGet]
        [Route("api/values/E-Commerce-ShoebApi/{productName}")]
        public IHttpActionResult GetEmployee(string productName)
        {
            return Json(BAL_itblProducts.GetProducts(productName));
        }
        //// POST api/values
        [HttpPost] 
        [Route("api/values/PostCredentials")]
        public IHttpActionResult PostCredentials([FromBody]EmailPasswordView credentials)
        {
            if (ModelState.IsValid)
            {
                return Json(BAL_iPostEmailPw.Post(credentials));
            }
            return Content(HttpStatusCode.BadRequest, "Request Failed");
        }
      

        [HttpPost]
        [Route("api/view/RegisterNewProduct")]
        public IHttpActionResult PostNewProduct([FromBody]AddProductView newProduct)
        {
            if (ModelState.IsValid)
            {
                BAL_iNewProduct.AddProduct(newProduct);
                return Ok(); 
            }
            return Content(HttpStatusCode.BadRequest, "Request Failed");
         }

        [HttpPost]
        [Route("api/view/GenerateOtp")]
        public void GenerateOtp(string email)
        {
            DAL_iGenererate.GenerateOTPviaEmail(email);
        }


        [HttpPost]
        [Route("api/view/RegisterNewUser")]
        public IHttpActionResult PostRegisterNewUser([FromBody]RegisterUserView user)
        {
            if (ModelState.IsValid)
            {
                if (DAL_iGenererate.VerifyOtp(user.Email, user.OTP))
                {
                    BAL_iRegisterUser.Register(user);
                    return Ok();
                }
            }
            return Content(HttpStatusCode.BadRequest, "Request Failed");
        }
        [HttpGet]
        [Route("api/view/GetSellerRequests")]
        public IHttpActionResult GetSellerRequests()
        {
            using(var db = new sdirecttestdbEntities())
            {
                return Json(db.SellerRequests_Sk().ToList());
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
