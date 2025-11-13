using Microsoft.EntityFrameworkCore;
using Villa.Models;

namespace Villa.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options)
            : base(options) 
        {
        }
        public DbSet<VillaModel> villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VillaModel>().HasData(
                new VillaModel()
                {
                    Id=1,
                    Name="Kiran",
                    Details="Thanks",
                    ImageUrl="sadf",
                    occupcys=2,
                    Rate=3,
                    sqft=4,
                    Amenity="",
                    createddate =DateTime.Now
                },
                new VillaModel()
                {
                    Id = 2,
                    Name = "ran",
                    Details = "Tdhanks",
                    ImageUrl = "sdadf",
                    occupcys = 23,
                    Rate = 33,
                    sqft = 43,
                    Amenity = "",
                    createddate = DateTime.Now
                },
                new VillaModel()
                {
                    Id = 3,
                    Name = "33Kiran",
                    Details = "Tfssfhanks",
                    ImageUrl = "sadf3f",
                    occupcys = 24,
                    Rate = 35,
                    sqft = 46,
                    Amenity = "",
                    createddate = DateTime.Now
                },
                new VillaModel()
                {
                    Id = 12,
                    Name = "K3reiran",
                    Details = "Trrhanks",
                    ImageUrl = "savcdf",
                    occupcys = 26,
                    Rate = 37,
                    sqft = 48,
                    Amenity = "",
                    createddate = DateTime.Now
                });
        }
    }
}
