using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using AsiaFridges.Models;

namespace AsiaFridges.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FridgeType> FridgeTypes { get; set; }
        public DbSet<Fridge> Fridges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for FridgeType

            modelBuilder.Entity<FridgeType>().HasData(
                new FridgeType { FridgeTypeID = 1, FridgeTypeName = "Top Freezer", DisplayOrder = 1 },
                new FridgeType { FridgeTypeID = 2, FridgeTypeName = "Bottom Freezer", DisplayOrder = 2 },
                new FridgeType { FridgeTypeID = 3, FridgeTypeName = "Side-by-Side", DisplayOrder= 3 },
                new FridgeType { FridgeTypeID = 4, FridgeTypeName = "Mini Fridge", DisplayOrder = 4 },
                new FridgeType { FridgeTypeID = 5, FridgeTypeName = "Wine Cooler", DisplayOrder= 5 },
                new FridgeType { FridgeTypeID = 6, FridgeTypeName = "Bar Fridge", DisplayOrder = 6 }
                );

            //Seed data for Fridge

            modelBuilder.Entity<Fridge>().HasData(
                new Fridge
                {
                    FridgeID = 1,
                    FridgeModel = "RT38K5982SL",
                    FridgeDescription = "Samsung Refrigerator ,stainless steel finish.",
                    FridgeCapacity = 350,
                    Price = 8499.99,  
                    FridgeStatus = "Available",
                },
    new Fridge
    {
        FridgeID = 2,
        FridgeModel = "LFC25760SW",
        FridgeDescription = "LG Bottom Freezer ,cooling efficiency.",
        FridgeCapacity = 400,
        Price = 3499.99,  
        FridgeStatus = "Available",
    },
    new Fridge
    {
        FridgeID = 3,
        FridgeModel = "GSS25GSHSS",
        FridgeDescription = "Side by Side , with ice maker.",
        FridgeCapacity = 500,
        Price = 12999.99,  // Price based on high-end GE models
        FridgeStatus = "Under Maintenance",
    },
    new Fridge
    {
        FridgeID = 4,
        FridgeModel = "Mini  WRT312CZJW",
        FridgeDescription = "Whirlpool, ideal for small space.",
        FridgeCapacity = 150,
        Price = 2499.99,  
        FridgeStatus = "Available",
    },
    new Fridge
    {
        FridgeID = 5,
        FridgeModel = "Wine Cooler 272 03 03",
        FridgeDescription = "Wine Enthusiast ,with temperature settings.",
        FridgeCapacity = 100,
        Price = 5299.99,  
        FridgeStatus = "Available",
    },
    new Fridge
    {
        FridgeID = 6,
        FridgeModel = "Bar  EFR492",
        FridgeDescription = "Frigidaire ,for beverages .",
        FridgeCapacity = 80,
        Price = 3699.99,  
        FridgeStatus = "In Transit",
    }
                );


        }
    }
}
