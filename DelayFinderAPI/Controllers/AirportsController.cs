using DelayFinderAPI.Entities;
using DelayFinderAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DelayFinderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportsController : Controller
    {
        private readonly IAirportService _airportService;

        public AirportsController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddAirport(Airport airport)
        {
            var airportDetails = await _airportService.AddAirport(airport);
            return airportDetails;
        }

        [HttpGet("{airportId}")]
        public async Task<ActionResult<List<Airport>>> GetAirportDetails(string airportId)
        {
            var airportDetails = await _airportService.GetAirportDetails(airportId);
            if (airportDetails == null || airportDetails.Count == 0)
            {
                return NotFound();
            }
            return airportDetails;
        }

    }

}
