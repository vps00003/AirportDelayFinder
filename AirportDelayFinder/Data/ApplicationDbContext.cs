using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DelayFinderAPI.Entities;


namespace AirportDelayFinder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                   : base(options)
        {
        }
        public DbSet<DelayFinderAPI.Entities.Airline> Airline { get; set; } = default!;
        public DbSet<DelayFinderAPI.Entities.Airport> Airport { get; set; } = default!;
        public DbSet<DelayFinderAPI.Entities.Flight> Flight { get; set; } = default!;
    }
}
