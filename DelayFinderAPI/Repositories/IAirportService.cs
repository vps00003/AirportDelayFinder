using DelayFinderAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DelayFinderAPI.Repositories
{
    public interface IAirportService
    {
        Task<int> AddAirport(Airport airport);

        Task<List<Airport>> GetAirportDetails(string airportId);

    }
}

