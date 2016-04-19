using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTestGit2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Om os";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pils computer service";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Vi tilbyde";

            return View();
        }
    }
}