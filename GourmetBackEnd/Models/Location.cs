using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Gourmet.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        public string? LocationName { get; set; }

        [ForeignKey("Restaurant")]
        public long RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}