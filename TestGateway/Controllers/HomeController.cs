using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGateway.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Домашняя страница";

            return View();
        }
        
        public ActionResult API()
        {
            ViewBag.Title = "APIs";

            return View();
        }
    }
}
