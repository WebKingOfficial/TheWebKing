using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheWebKing.Controllers
{
    public class ErrorController : Controller
    {
        [HandleError]
        public ActionResult FileNotFound()
        {
            return View();
        }
    }
}