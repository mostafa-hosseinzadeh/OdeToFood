using System.Collections.Generic;
using System.Linq;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> resturants;

        public IEnumerable<Restaurant> GetAll()
        {
            resturants = new List<Restaurant>()
            {
                new Restaurant() {Id=1, Name="Cesare",Cuisine = CuisineType.Italian},
                new Restaurant() {Id=2, Name="Tersiguels",Cuisine = CuisineType.French},
                new Restaurant() {Id=3, Name="Taj Mahal",Cuisine = CuisineType.Indian},
                new Restaurant() {Id=3, Name="Vakil",Cuisine = CuisineType.Iranian}
            };
            return resturants.OrderBy(r => r.Name);
        }
    }
}