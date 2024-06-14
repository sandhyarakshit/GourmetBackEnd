using System.Collections.Generic;
using System.Linq;
using Gourmet.Models;
using Microsoft.EntityFrameworkCore;

namespace GourmetBackEnd.Repository
{
    public class ItemRepository  
    {
        private readonly GourmetDbContext _context;

        public ItemRepository(GourmetDbContext context)
        {
            _context = context;
        }

        public List<Item> GetUnavailableItemsByLocationId(int locationId)
        {
            return _context.Items.Where(i => i.LocationId == locationId && !i.Available).ToList();
        }
    }
}