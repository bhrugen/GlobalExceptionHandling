using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WhatsWrongAPI.Models;

namespace WhatsWrongAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaAmenity> VillaAmenities { get; set; }
        public DbSet<VillaCategory> VillaCategories { get; set; }
        public DbSet<VillaSpeciality> VillaSpecialities { get; set; }
        public DbSet<VillaPricing> VillaPricings { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Villa>().HasData(
              new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Price = 200,
                },
              new Villa
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Price = 300,
                },
              new Villa
              {
                  Id = 3,
                  Name = "Luxury Pool Villa",
                  Price = 400,
              },
              new Villa
              {
                  Id = 4,
                  Name = "Luxury1 Pool Villa",
                  Price = 400,
              },
              new Villa
              {
                  Id = 5,
                  Name = "Royal Villa 55",
                  Price = 55,
              });


            modelBuilder.Entity<VillaAmenity>().HasData(
              new VillaAmenity
              {
                  Id = 1,
                  VillaId = 1,
                  Name = "Private Pool"
              }, 
              new VillaAmenity
              {
                  Id = 2,
                  VillaId = 1,
                  Name = "Microwave"
              }, 
              new VillaAmenity
              {
                  Id = 3,
                  VillaId = 1,
                  Name = "Private Balcony"
              }, 
              new VillaAmenity
              {
                  Id = 4,
                  VillaId = 1,
                  Name = "1 king bed and 1 sofa bed"
              },
              new VillaAmenity
              {
                  Id = 5,
                  VillaId = 2,
                  Name = "Private Plunge Pool"
              }, 
              new VillaAmenity
              {
                  Id = 6,
                  VillaId = 2,
                  Name = "Microwave and Mini Refrigerator"
              },
              new VillaAmenity
              {
                  Id = 9,
                  VillaId = 3,
                  Name = "Private Pool"
              }, 
              new VillaAmenity
              {
                  Id = 10,
                  VillaId = 3,
                  Name = "Jacuzzi"
              }, 
              new VillaAmenity
              {
                  Id = 11,
                  VillaId = 3,
                  Name = "Private Balcony"
              });

        }
    }
}
