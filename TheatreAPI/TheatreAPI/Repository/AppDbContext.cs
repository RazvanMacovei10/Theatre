using Microsoft.AspNetCore.Mvc.Infrastructure;
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
        public DbSet<PlayType> PlayTypes { get; set; }
        public DbSet<Play> Plays { get; set; }
        public DbSet<UserRole> Roles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<RegisterForm> RegisterForms { get; set; }

    }
}
