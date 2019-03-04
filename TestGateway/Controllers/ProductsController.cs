using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using NLog;
using TestRest.Models;
using TestRest.Service;

//using System.Web.Mvc;

namespace TestRest.Controllers
{
    public class ProductsController : ApiController
    {
        
        private static Logger log = LogManager.GetCurrentClassLogger();
        Product[] products = new Product[]
        {
            new Product
            {
                id = 1, 
                name = "Art"
            }, 
            new Product
            {
                id = 2,
                name = "Vasia"
            }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            log.Info("INIT");
            
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
//            var product = products.FirstOrDefault((p) => p.id == id);
//            if (product == null)
//            {
//                return NotFound();
//            }

            try
            {
//                return Ok(new LimsService().RunAction("Hello"));
                return Ok("Hello");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        [HttpPost]
        public HttpResponseMessage createProduct(Product product)
        {
            
            log.Info("INIT");

//            if (ModelState.IsValid)
//            {
                return  new HttpResponseMessage(HttpStatusCode.Created);
//            }

//            new LimsService().UserLogin("test", "test");
//
////            Console.WriteLine(product);
//            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }
      
    }
}