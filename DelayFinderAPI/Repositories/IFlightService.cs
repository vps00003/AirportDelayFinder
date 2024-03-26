using System;
using System.Threading.Tasks;

namespace DelayFinderAPI.Repositories
{
    public interface IFlightService
    {
        Task<double?> SearchFlightDelays(string departureAirportID, DateTime departureTime);
    }
}
