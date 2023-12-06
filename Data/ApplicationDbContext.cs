using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalProjectPCCapstone2023.Data.Migrations;
using PersonalProjectPCCapstone2023.Models;

namespace PersonalProjectPCCapstone2023.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> RoleUsers { get; set; }

        public DbSet<Merchandise> Merch { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<MerchCategory> MerchCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Merchandise>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Merch)
                .UsingEntity<MerchCategory>();
            modelBuilder.Entity<Merchandise>().HasData(
            new Merchandise
            {
                MerchId = 1,
                MerchName = "T-Shirt",
                MerchPrice = 25.0m,
                ImagePath = "/Images/Tshirt.jpg"
            },
            new Merchandise
            {
                MerchId = 2,
                MerchName = "Sweater",
                MerchPrice = 35.0m,
                ImagePath = "/Images/Sweater.jpg"
            },
            new Merchandise
            {
                MerchId = 3,
                MerchName = "Hoodie",
                MerchPrice = 40.0m,
                ImagePath = "/Images/Hoodie.jpg"
            },
            new Merchandise
            {
                MerchId = 4,
                MerchName = "Hat",
                MerchPrice = 20.0m,
                ImagePath = "/Images/Hat.jpg"
            },
            new Merchandise
            {
                MerchId = 5,
                MerchName = "Beanie",
                MerchPrice = 21.0m,
                ImagePath = "/Images/Beanie.jpg"
            },
            new Merchandise
            {
                MerchId = 6,
                MerchName = "Backpack",
                MerchPrice = 30.0m,
                ImagePath = "/Images/Other.jpg"
            }
            );
            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                CategoryName = "T-Shirt",
                CategoryType = CategoryType.TSHIRT
            },
            new Category
            {
                CategoryId = 2,
                CategoryName = "Sweater",
                CategoryType = CategoryType.SWEATER
            },
            new Category
            {
                CategoryId = 3,
                CategoryName = "Hat",
                CategoryType = CategoryType.HAT
            },
            new Category
            {
                CategoryId = 4,
                CategoryName = "Hoodie",
                CategoryType = CategoryType.HOODIE
            },
            new Category
            {
                CategoryId = 5,
                CategoryName = "Beanie",
                CategoryType = CategoryType.BEANIE
            },
            new Category
            {
                CategoryId = 6,
                CategoryName = "Other",
                CategoryType = CategoryType.OTHER
            }
            );
        }
    }
}