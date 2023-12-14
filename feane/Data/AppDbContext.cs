using Feane.Models;
using Microsoft.EntityFrameworkCore;

namespace Feane.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Meal> Meals { get; set; }
        public DbSet<Customers> Customers { get; set; }
    }
}
