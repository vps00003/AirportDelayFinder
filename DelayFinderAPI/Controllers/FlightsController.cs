using DelayFinderAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DelayFinderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;

        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("searchDelay")]
        public async Task<ActionResult<double?>> SearchFlightDelays(string departureAirportID, DateTime departureTime)
        {
            var averageDelay = await _flightService.SearchFlightDelays(departureAirportID, departureTime);
            if (averageDelay == null)
            {
                return NotFound("No flights found for the given criteria");
            }

            return Ok(averageDelay);
        }
    }
}

