using Gourmet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GourmetBackEnd.Interfaces;

namespace GourmetBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _locationService;

        public LocationController(ILocationRepository locationService)
        {
            _locationService = locationService;
        }

        // GET: api/locations/restaurant/{restaurantId}
        [HttpGet("restaurant/{restaurantId}")]
        public ActionResult<List<Location>> GetLocationsByRestaurantId(long restaurantId)
        {
            return _locationService.GetLocationsByRestaurantId(restaurantId);
        }

        // GET: api/locations/restaurant/{restaurantId}/{locationName}
        [HttpGet("restaurant/{restaurantId}/{locationName}")]
        public ActionResult<Location> GetLocationByNameAndRestaurantId(string locationName, long restaurantId)
        {
            return _locationService.GetLocationByNameAndRestaurantId(locationName, restaurantId);
        }
    }
}
