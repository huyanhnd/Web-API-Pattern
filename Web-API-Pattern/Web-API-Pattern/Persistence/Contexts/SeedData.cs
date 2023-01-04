using System.Collections.Generic;
using System.Threading.Tasks;
using Web_API_Pattern.Domain.Models;

namespace Web_API_Pattern.Persistence.Contexts
{
    public static class SeedData
    {
        public static async Task Seed(AppDbContext context)
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 100,
                    Name = "Apple",
                    QuantityInPackage = 1,
                    UnitOfMeasurement = EUnitOfMeasurement.Unity,
                    CategoryId = 100
                },
                new Product
                {
                    Id = 101,
                    Name = "Milk",
                    QuantityInPackage = 2,
                    UnitOfMeasurement = EUnitOfMeasurement.Liter,
                    CategoryId = 101,
                }
            };

            var categories = new List<Category>
            {
                new Category { Id = 100, Name = "Fruits and Vegetables" }, // Id set manually due to in-memory provider
                new Category { Id = 101, Name = "Dairy" }
            };

            context.Products.AddRange(products);
            context.Categories.AddRange(categories);

            await context.SaveChangesAsync();
        }
    }
}