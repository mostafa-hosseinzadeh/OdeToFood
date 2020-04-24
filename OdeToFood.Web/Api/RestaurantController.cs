using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OdeToFood.Data.Models;
using OdeToFood.Data.Services;

namespace OdeToFood.Web.Api
{
    public class RestaurantController : ApiController
    {
        private readonly IRestaurantData db;
        public RestaurantController(IRestaurantData db)
        {
            this.db = db;
        }

        public IEnumerable<Restaurant> Get()
        {
           var model = db.GetAll().ToList();
            return model;
        }
    }
}
