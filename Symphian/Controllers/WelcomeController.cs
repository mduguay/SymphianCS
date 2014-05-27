using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Symphian.Controllers
{
    public class WelcomeController : Controller
    {
        //
        // GET: /Welcome/

        public ActionResult Splash()
        {
            ViewBag.Message = "Welcome to Symphian. There's more here than meets the eye... really!";

            return View();
        }

    }
}
