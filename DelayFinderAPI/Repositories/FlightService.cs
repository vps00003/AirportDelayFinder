using DelayFinderAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace DelayFinderAPI.Repositories
{
    public class FlightService : IFlightService
    {
        private readonly DbContextClass _dbContextClass;

        public FlightService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<double?> SearchFlightDelays(string departureAirportID, DateTime departureTime)
        {
            var departureAirportIDParam = new SqlParameter("@DepartureAirportID", departureAirportID);
            var departureTimeParam = new SqlParameter("@DepartureTime", departureTime);

            var flights = await _dbContextClass.Flights
                .FromSqlRaw("exec searchFlightDelays @DepartureAirportID, @DepartureTime",
                    departureAirportIDParam, departureTimeParam)
                .ToListAsync();

            var averageDelay = flights.Select(f => f.FlightDelayMinutes).FirstOrDefault();

            return averageDelay;
        }

    }
}



