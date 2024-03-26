using DelayFinderAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DelayFinderAPI.Repositories
{
    public interface IAirlineService
    {
        public Task<List<Airline>> AirlineDelayRatings(string AirlineID);

        public Task<List<Airline>> GetAirlinesRatingGreaterThan(string delayRating);

        public Task<int> AddAirline(Airline airline);

    }
}
