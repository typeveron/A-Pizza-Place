using Microsoft.EntityFrameworkCore;
using Pizza_Place.Models;


namespace Pizza_Place.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrdersCollection { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}

