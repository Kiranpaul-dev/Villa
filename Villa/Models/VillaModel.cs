namespace Villa.Models
{
    public class VillaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public double? Rate { get; set; }
        public string? ImageUrl { get; set; }
        public string Amenity { get; set; }
        public DateTime createddate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int occupcys { get; set; }
        public int sqft { get; set; }
    }
}
