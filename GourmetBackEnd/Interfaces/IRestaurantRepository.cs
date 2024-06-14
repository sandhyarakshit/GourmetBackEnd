using System.Collections.Generic;
using Gourmet.Models;   

namespace GourmetBackEnd.Interfaces
{
    public interface IRestaurantRepository
    {
         List<Restaurant> FindAll();
        Restaurant FindById(long id);
        Restaurant FindByName(string name);
    }
} 