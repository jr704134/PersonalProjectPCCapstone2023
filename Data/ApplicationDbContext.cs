using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalProjectPCCapstone2023.Models;

namespace PersonalProjectPCCapstone2023.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Merchandise> Merch { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> RoleUsers { get; set; }

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
                    MerchName = "Test",
                    MerchPrice = 25.0m,
                    MerchSize = "Medium"
                }
                );

        }
    }
}