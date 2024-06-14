using Gourmet.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace GourmetBackEnd.Repository
{
    public class RestaurantRepository
    {
        private readonly GourmetDbContext _dbContext;
        public RestaurantRepository(GourmetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _dbContext.Restaurants.ToList();
        }

        public Restaurant GetRestaurantById(long id)
        {
            return _dbContext.Restaurants.FirstOrDefault(r => r.RestaurantId == id);
        }

        public Restaurant GetRestaurantByName(string name)
        {
            return _dbContext.Restaurants.FirstOrDefault(r => r.Name == name);
        }
    }
}
