using Microsoft.EntityFrameworkCore;
using fractal_back.Models;

namespace fractal_back.Data
{
	public class AppDbContext: DbContext
	{

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
