using System.Collections.Generic;
using System.Linq;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> resturants;

        public InMemoryRestaurantData()
        {
            resturants = new List<Restaurant>()
            {
                new Restaurant() {Id=1, Name="Cesare",Cuisine = CuisineType.Italian},
                new Restaurant() {Id=2, Name="Tersiguels",Cuisine = CuisineType.French},
                new Restaurant() {Id=3, Name="Taj Mahal",Cuisine = CuisineType.Indian},
                new Restaurant() {Id=3, Name="Vakil",Cuisine = CuisineType.Iranian}
            };
        }

       public Restaurant Get(int id)
        {
            return resturants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return resturants.OrderBy(r => r.Name);
        }

        public void Add(Restaurant restaurant)
        {
            resturants.Add(restaurant);
            restaurant.Id = resturants.Max(r => r.Id) + 1; //Never do this in production!

        }
        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);
            if (existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }

        public void Delete(int id)
        {
            var restaurant = Get(id);
            if (restaurant != null)
            {
                resturants.Remove(restaurant);
            }
        }
    }
}