using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheStore.Data;
using System;
using System.Linq;

namespace TheStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RobotoDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<RobotoDbContext>>()))
            {
                if (context.Products.Any()) return;

                context.Products.AddRange(
                new Product
                {
                    Name = "iPhone 11 Pro",
                    SKU = "11111",
                    Price = 610.00M,
                    Description = "With its 6.1-inch display, the iPhone 11 is between the 5.8-inch iPhone 11 Pro and 6.5-inch iPhone 11 Pro Max in size. The iPhone 11 has an edge-to-edge display with slim bezels and no Home button, adopting a notch at the top for the TrueDepth camera system.",
                    ImgUrl = "/Assets/iphone_11_pro.jpg",
                },

                new Product
                {
                    Name = "iPhone 12 Pro",
                    SKU = "22222",
                    Price = 1079.00M,
                    Description = "Meet the new iPhone 12 and iPhone 12 mini. 5G speed. A14 Bionic. Super Retina XDR display. Ceramic Shield. And Night mode on every camera.",
                    ImgUrl = "/Assets/iphone_12_pro.jpg",
                },

                new Product
                {
                    Name = "Samsung Galaxy S21 Ultra 5G",
                    SKU = "33333",
                    Price = 1076.90M,
                    Description = "Galaxy S21 Ultra 5G, epic in every way. Its camera revolutionizes photography and 8K video with 108MP resolution, a 5nm processor and an all-day battery.",
                    ImgUrl = "/Assets/samsung_galaxy_s21.jpg",
                },

                new Product
                {
                    Name = "Samsung Galaxy S20",
                    SKU = "44444",
                    Price = 607.48M,
                    Description = "The phone that will change photography with revolutionary 8K video snap. 5G changes how you share it.",
                    ImgUrl = "/Assets/samsung_galaxy_s20.webp",
                });

                context.SaveChanges();
            }
        }
    }
}