using DelayFinderAPI.Entities;
using DelayFinderAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

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
    }
}


