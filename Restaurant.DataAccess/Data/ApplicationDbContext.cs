using Microsoft.EntityFrameworkCore;
using Restaurant2.Models;

namespace Restaurant.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }
    }
}
