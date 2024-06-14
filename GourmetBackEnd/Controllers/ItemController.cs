using Gourmet.Models;
using GourmetBackEnd.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GourmetBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _itemService;

        public ItemController(IItemRepository itemService)
        {
            _itemService = itemService;
        }

        // GET: api/items/location/{locationId}
        [HttpGet("location/{locationId}")]
        public ActionResult<List<Item>> GetUnavailableItemsByLocationId(int locationId)
        {
            return _itemService.GetUnavailableItemsByLocationId(locationId);
        }
    }
}
