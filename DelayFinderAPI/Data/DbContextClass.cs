using DelayFinderAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DelayFinderAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }

        public DbSet<Airline> Airline { get; set; }
        public DbSet<Airport> Airport { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public async Task<List<Airport>> GetAirportDetails(string airportId)
        {
            var airportIdParam = new SqlParameter("@AirportID", airportId);
            return await Airport.FromSqlRaw("exec GetAirportDetails @AirportID", airportIdParam).ToListAsync();
        }
    }
}
