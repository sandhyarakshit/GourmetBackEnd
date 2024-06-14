using System.ComponentModel.DataAnnotations;

namespace Gourmet.Models
{
    public class Restaurant
    {
        [Key]
        public long RestaurantId { get; set; }

        public string? Name { get; set; }
    }
}