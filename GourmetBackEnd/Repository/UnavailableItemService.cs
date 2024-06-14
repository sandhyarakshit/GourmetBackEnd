using System;
using System.Collections.Generic;
using Gourmet.Models;
using GourmetBackEnd.Repository;
using System;
using System.Collections.Generic;

namespace GourmetBackEnd.Repository
{
    public class UnavailableItemService
    {
        private readonly RestaurantRepository _restaurantRepository;
        private readonly LocationRepository _locationRepository;
        private readonly ItemRepository _itemRepository;

        public UnavailableItemService(RestaurantRepository restaurantRepository, LocationRepository locationRepository, ItemRepository itemRepository)
        {
            _restaurantRepository = restaurantRepository;
            _locationRepository = locationRepository;
            _itemRepository = itemRepository;
        }

        public List<Item> GetUnavailableItems(string restaurantName, string locationName)
        {
            // Fetch the restaurant by name
            Restaurant restaurant = _restaurantRepository.GetRestaurantByName(restaurantName);
            if (restaurant == null)
            {
                throw new Exception("Restaurant not found");
            }

            // Fetch the location by name and restaurant
            Location location = _locationRepository.GetLocationByNameAndRestaurantId(locationName, restaurant.RestaurantId);
            if (location == null)
            {
                throw new Exception("Location not found");
            }

            // Fetch the unavailable items by location
            return _itemRepository.GetUnavailableItemsByLocationId(location.Id);
        }
    }
}
