using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tik4NetWala.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tik4Net Wala (Mikrotik Networking Call Using TikCommand)";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact with me For Help or Integration.";
            return View();
        }
    }
}