using System.ComponentModel.DataAnnotations;

namespace Villa.Models.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
        public int occupcys { get; set; }
        public int sqft { get; set; }
    }
}
