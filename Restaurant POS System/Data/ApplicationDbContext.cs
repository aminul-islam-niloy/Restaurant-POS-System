using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant_POS_System.Models;

namespace Restaurant_POS_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Inventory> Inventorys { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Table> Tables { get; set; }

    }
}
