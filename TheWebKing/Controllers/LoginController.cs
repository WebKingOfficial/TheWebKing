using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheWebKing.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult UserLogin()
        {
            return View();
        }
    }
}