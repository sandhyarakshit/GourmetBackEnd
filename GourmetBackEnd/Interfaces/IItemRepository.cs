using System.Collections.Generic;
using Gourmet.Models;


namespace GourmetBackEnd.Interfaces
{
    public interface IItemRepository
    {
        List<Item> GetUnavailableItemsByLocationId(int locationId);
    }
}