using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Data.Models;
using OdeToFood.Data.Services;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData restaurantData;
        public ActionResult Index()
        {
            var inMemoryRestaurantData = new InMemoryRestaurantData();
            var model = inMemoryRestaurantData.GetAll();
            return View(model);
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