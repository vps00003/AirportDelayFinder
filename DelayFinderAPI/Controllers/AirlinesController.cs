using DelayFinderAPI.Entities;
using DelayFinderAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DelayFinderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlinesController : ControllerBase
    {
        private readonly IAirlineService _airlineService;

        public AirlinesController(IAirlineService airlineService)
        {
            _airlineService = airlineService;
        }

        [HttpGet("{AirlineID}")]
        public async Task<ActionResult<List<Airline>>> AirlineDelayRatings(string AirlineID)
        {
            var AirlineDelayRating = await _airlineService.AirlineDelayRatings(AirlineID);
            if (AirlineDelayRating == null)
            {
                return NotFound();
            }
            return AirlineDelayRating;
        }

        [HttpGet("delay-rating-greater-than/{delayRating}")]
        public async Task<ActionResult<List<Airline>>> GetAirlinesRatingGreaterThan(string delayRating)
        {
            var airlines = await _airlineService.GetAirlinesRatingGreaterThan(delayRating);
            if (airlines == null || airlines.Count == 0)
            {
                return NotFound();
            }
            return Ok(airlines);
        }
        [HttpPost]
        public async Task<ActionResult<int>> AddAirline(Airline airline)
        {
            var airlineDetails = await _airlineService.AddAirline(airline);
            return airlineDetails;
        }


    }
}



