using DelayFinderAPI.Data;
using DelayFinderAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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
    }
}