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

        public ViewController(BAL_ISearchProduct BAL_itblProducts, BAL_IPostEmailPw BAL_iPostEmailPw, BAL_INewProduct BAL_iNewProduct)
        {
            this.BAL_itblProducts = BAL_itblProducts;
            this.BAL_iPostEmailPw = BAL_iPostEmailPw;
            this.BAL_iNewProduct = BAL_iNewProduct;
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

            return Content(HttpStatusCode.BadRequest, "Request Failed");
        }
      

        [HttpPost]
        [Route("api/view/PostNewProduct")]
        public IHttpActionResult PostNewProduct([FromBody]AddProductView newProduct)
        {
            if (ModelState.IsValid)
            {
                BAL_iNewProduct.AddProduct(newProduct);
                return Ok(); 
            }
            return Content(HttpStatusCode.BadRequest, "Request Failed");

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
