using System.Collections.Generic;
using Gourmet.Models; 
namespace GourmetBackEnd.Interfaces
{
    public interface ILocationRepository
    {
        List<Location> GetLocationsByRestaurantId(long restaurantId);

        Location GetLocationByNameAndRestaurantId(string locationName, long restaurantId);
    }
}