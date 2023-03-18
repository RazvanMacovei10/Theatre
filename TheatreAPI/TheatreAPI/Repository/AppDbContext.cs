using Microsoft.EntityFrameworkCore;
using TheatreAPI.Models;

namespace TheatreAPI.Repository
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Actor> Actors { get; set; }

    }
}
