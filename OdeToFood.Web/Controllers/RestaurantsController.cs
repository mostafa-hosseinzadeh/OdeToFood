using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Data.Services;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private IRestaurantData db;

        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }


        // GET: Restaurants
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
    }
}