using fractal_back.Models;

namespace fractal_back.Data;

public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        
        context.Database.EnsureCreated();

       
        if (context.Products.Any())
        {
            return;
        }

        var products = new Product[]
        {
            new Product { Name = "Laptop", Price = 120, Quantity = 70 },
            new Product { Name = "Smartphone", Price = 800, Quantity = 5 },
            new Product { Name = "mouse", Price = 10, Quantity = 2 }
        };

        context.Products.AddRange(products);
        context.SaveChanges();
    }
}
