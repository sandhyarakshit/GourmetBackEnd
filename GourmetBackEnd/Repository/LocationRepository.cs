using System.Collections.Generic;
using Gourmet.Models;
using GourmetBackEnd.Repository;
using GourmetBackEnd.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GourmetBackEnd.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly GourmetDbContext dbContext;

        public LocationRepository(GourmetDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Location> GetLocationsByRestaurantId(long restaurantId)
        {
             return dbContext.Locations
                        .Where(l => l.RestaurantId == restaurantId)
                        .ToList();
        }

        public Location GetLocationByNameAndRestaurantId(string locationName, long restaurantId)
        {
            return dbContext.Locations
                   .FirstOrDefault(l => l.LocationName == locationName && l.RestaurantId == restaurantId);
        }
    }
}

