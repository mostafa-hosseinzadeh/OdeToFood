using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaurantData(OdeToFoodDbContext  db)
        {
            this.db = db;
        }
        public void Add(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            //return db.Restaurants;
            return from r in db.Restaurants
                   orderby r.Name
                   select r;
        }

        public void Update(Restaurant restaurant)
        {
            ////mycode
            //var existing = db.Restaurants.FirstOrDefault(r => r.Id == id);
            //if(existing != null)
            //{
            //    existing.Name = restaurant.Name;
            //    existing.Cuisine = restaurant.Cuisine;
            //    db.SaveChanges();
            //}

            ////Scott's Code without Concurency Consideration: Last user in, with the updates will win!
            //var r = Get(restaurant.Id);
            //r.Name = restaurant.Name;
            //r.Cuisine = restaurant.Cuisine;
            //db.SaveChanges();

            //Scott's code with Optimistic Concurency
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
