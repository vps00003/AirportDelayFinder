using DelayFinderAPI.Data;
using DelayFinderAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DelayFinderAPI.Repositories
{
    public class AirportService : IAirportService
    {
        private readonly DbContextClass _dbContextClass;

        public AirportService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<int> AddAirport(Airport airport)
        {
            var cityID = new SqlParameter("@CityID", airport.CityID);
            var airportID = new SqlParameter("@AirportID", airport.AirportID);
            var airportName = new SqlParameter("@AirportName", airport.AirportName);
            var runwayCount = new SqlParameter("@AirportRunwayCount", airport.AirportRunwayCount);
            var avgPassengers = new SqlParameter("@AirportAvgYearlyPassengers", airport.AirportAvgYearlyPassengers);
            var destinationCount = new SqlParameter("@AirportDestinationCount", airport.AirportDestinationCount);

            var airportDetails = await _dbContextClass.Database.ExecuteSqlRawAsync("exec InsertAirport @CityID, @AirportID, @AirportName, @AirportRunwayCount, @AirportAvgYearlyPassengers, @AirportDestinationCount", cityID, airportID, airportName, runwayCount, avgPassengers, destinationCount);

            return airportDetails;
        }
        public async Task<List<Airport>> GetAirportDetails(string airportId)
        {
            return await _dbContextClass.GetAirportDetails(airportId);
        }

    }

}
