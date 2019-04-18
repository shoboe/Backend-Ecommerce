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

        public ViewController(BAL_ItblProducts BAL_itblProducts)
        {
            this.BAL_itblProducts = BAL_itblProducts;
        }

        [HttpGet]
        [Route("api/values/E-Commerce-ShoebApi/{productName}")]
        public IHttpActionResult GetEmployee(string productName)
        {
            return Json(BAL_itblProducts.GetProducts(productName));
        }
        //// POST api/values
        //[HttpPost]
        //[Route("api/values/UserPw/{user}")]
        //public IHttpActionResult PostUserPw(UserPwSk user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (myIBusinessAL.PostUserPw(user))
        //            return Ok();
        //        else
        //            return Content(HttpStatusCode.BadRequest, "Request Successfull");
        //    }

        //    return Content(HttpStatusCode.BadRequest, "Request Successfull");
        //}

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
