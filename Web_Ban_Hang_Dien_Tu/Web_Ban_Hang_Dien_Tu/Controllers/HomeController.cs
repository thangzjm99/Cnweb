using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Ban_Hang_Dien_Tu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Name = "Dinh quoc thang";

            return View();
        }

        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

       

       
    }
}