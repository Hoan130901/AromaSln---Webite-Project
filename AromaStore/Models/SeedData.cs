using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace AromaStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Quartz Watch",
                        Description = "Gold-platedwith diamond-studs",
                        Category = "Accessories",
                        Price = 100000,
                        Image = "product1.png"
                    },
                    new Product
                {
                    Name = "Skin Cream",
                    Description = "Protective and fashionable",
                    Category = "Beauty",
                    Price = 20,
                    Image = "product2.png"
                },
                    new Product
                {
                    Name = "Wall Light",
                    Description = "Modern wall light",
                    Category = "Decor",
                    Price = 100,
                    Image = "product3.png"
                },
                    new Product
                {
                    Name = "Hot Water Bottle",
                    Description = "For those cold nights",
                    Category = "Accessories",
                    Price = 10.25m,
                    Image = "product4.png"
                },
                    new Product
                {
                    Name = "Man Bag",
                    Description = "For a man on the run",
                    Category = "Accessories",
                    Price = 35,
                    Image = "product5.png"
                },
                    new Product
                {
                    Name = "Sports Car",
                    Description = "Radio controlled car",
                    Category = "Toys",
                    Price = 15,
                    Image = "product6.png"
                },
                    new Product
                {
                    Name = "Blutooth Speaker",
                    Description = "Great bass, crisp heighs",
                    Category = "Accessories",
                    Price = 87.50m,
                    Image = "product7.png"
                },
                    new Product
                {
                    Name = "Car Charger",
                    Description = "For your toy car",
                    Category = "Toys",
                    Price = 27.85m,
                    Image = "product8.png"
                },
                    new Product
                {
                    Name = "Child's Watch",
                    Description = "Looks like the real thing",
                    Category = "Toys",
                    Price = 25,
                    Image = "product1.png"
                }
                );
                context.SaveChanges();
            }
        }
    }
}