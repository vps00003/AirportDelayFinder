using DelayFinderAPI.Entities;

namespace DelayFinderAPI.Repositories
{
    public interface IAirlineService
    {
        public Task<List<Airline>> AirlineDelayRatings(string AirlineID);
    }
}
