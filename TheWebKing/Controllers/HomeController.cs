using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheWebKing.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
            return View();
        }

        [HandleError]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HandleError]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// The error method will come when Controller 
        /// is there but View is not present
        /// </summary>
        /// <returns></returns>
        public ActionResult Error()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}