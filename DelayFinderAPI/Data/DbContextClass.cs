using DelayFinderAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DelayFinderAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        public DbSet<Airline> Airline { get; set; }
    }
}
