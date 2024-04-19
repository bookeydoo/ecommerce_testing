using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;


namespace Ecommerce.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EcommerceContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EcommerceContext>>()))
            {
                if (context == null || context.General_item_layout == null)
                {
                    throw new ArgumentNullException("Null EcommerceContext");
                }

                // Look for any General_item_layout s.
                if (context.General_item_layout.Any())
                {
                    return;   // DB has been seeded
                }

                context.General_item_layout.AddRange(
                    new General_item_layout
                    {
                        Id = "pizza",
                        DB_id = 4,
                        Dateofproduction = DateTime.Parse("1989-2-12"),
                        Price = 50,
                        rating = 3
                    },

                    new General_item_layout
                    {
                        Id = "tshirt",
                        DB_id = 5,
                        Dateofproduction = DateTime.Parse("1989-2-12"),
                        Price = 50,
                        rating = 3
                    },

                    new General_item_layout
                    {
                        Id = "y",
                        DB_id = 2,
                        Dateofproduction = DateTime.Parse("1989-2-12"),
                        Price = 50,
                        rating = 3
                    },

                    new General_item_layout
                    {
                        Id = "x",
                        DB_id = 15,
                        Dateofproduction = DateTime.Parse("1989-2-12"),
                        Price = 5,
                        rating = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}