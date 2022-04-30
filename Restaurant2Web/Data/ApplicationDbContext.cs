using Microsoft.EntityFrameworkCore;
using Restaurant2Web.Models;

namespace RestaurantWeb2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }
    }
}
