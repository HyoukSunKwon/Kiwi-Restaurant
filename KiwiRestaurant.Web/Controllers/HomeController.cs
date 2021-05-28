using KiwiRestaurant.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiwiRestaurant.Web.Controllers
{
    public class HomeController : Controller
    {
        IFoodData db;

        public HomeController(IFoodData db)
        {
            this.db = db;  
        }
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

            return View();
        }

    }
}