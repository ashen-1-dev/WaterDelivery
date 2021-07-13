using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WaterDelivery.Models;

namespace WaterDelivery.Controllers
{
    public class HomeController : Controller
    {
        DeliveryContext db = new DeliveryContext();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Users = db.Users;
           
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}