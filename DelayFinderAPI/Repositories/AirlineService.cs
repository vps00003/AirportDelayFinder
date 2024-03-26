using DelayFinderAPI.Data;
using DelayFinderAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DelayFinderAPI.Repositories
{
    public class AirlineService : IAirlineService
    {
        private readonly DbContextClass _dbContextClass;

        public AirlineService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Airline>> AirlineDelayRatings(string AirlineID)
        {
            var param = new SqlParameter("@AirlineID", AirlineID);
            var AirlineDelayRating = await Task.Run(() => _dbContextClass.Airline.FromSqlRaw("exec getAirlineDelayRatings @AirlineID", param).ToListAsync());
            return AirlineDelayRating;
        }

        public async Task<List<Airline>> GetAirlinesRatingGreaterThan(string delayRating)
        {
            var param = new SqlParameter("@DelayRating", delayRating);
            var airlines = await _dbContextClass.Airline
                .FromSqlRaw("EXEC GetAirlinesRatingGreaterThan @DelayRating", param)
                .ToListAsync();

            return airlines;
        }
        public async Task<int> AddAirline(Airline airline)
        {
            var airlineID = new SqlParameter("@AirlineID", airline.AirlineID);
            var airlineName = new SqlParameter("@AirlineName", airline.AirlineName);
            var airlineRating = new SqlParameter("@AirlineRating", airline.AirlineRating);
            var airlineDelayRating = new SqlParameter("@AirlineDelayRating", airline.AirlineDelayRating);

            var airlineDetails = await _dbContextClass.Database.ExecuteSqlRawAsync("exec InsertAirline @AirlineID, @AirlineName, @AirlineRating, @AirlineDelayRating", airlineID, airlineName, airlineRating, airlineDelayRating);

            return airlineDetails;
        }
    }
    }

