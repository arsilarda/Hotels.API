using Microsoft.EntityFrameworkCore;

namespace Hotels.API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Hotel> Hotels { get; set; }
    }
}
