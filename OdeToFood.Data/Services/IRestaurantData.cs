using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
