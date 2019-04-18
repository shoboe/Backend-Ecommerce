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
using E_Commerce_ShoebApi.Models;
using Newtonsoft.Json;

namespace E_Commerce_ShoebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ViewController : ApiController
    {
        BAL_ItblProducts BAL_itblProducts;
        BAL_IPostEmailPw BAL_iPostEmailPw;

        public ViewController(BAL_ItblProducts BAL_itblProducts, BAL_IPostEmailPw BAL_iPostEmailPw)
        {
            this.BAL_itblProducts = BAL_itblProducts;
            this.BAL_iPostEmailPw = BAL_iPostEmailPw;
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
        public IHttpActionResult PostCredentials([FromBody]EmailPasswordView emailPasswordView )
        {
            if (ModelState.IsValid)
            {

                return Json(BAL_iPostEmailPw.Post(emailPasswordView.Email, emailPasswordView.Password));
            }

            return Content(HttpStatusCode.BadRequest, "Request Successfull");
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
