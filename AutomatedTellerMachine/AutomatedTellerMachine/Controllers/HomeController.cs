using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "TEST TEXT.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "TEST TEXT.";
            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }
        public ActionResult Serial(string letterCase)
        {
            var serial = "jkhaskdjh";
            if (letterCase == "x")
            {
                return Content(letterCase);
            }
            else
            {
                return Content(letterCase);

            }
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thanks we got you message";

            return View();
        }

    }
}