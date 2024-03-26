using System.ComponentModel.DataAnnotations;

namespace DelayFinderAPI.Entities
{
    public class Airline
    {
        public string AirlineID { get; set; }
        public string AirlineName { get; set; }
        public string AirlineRating { get; set; }
        public string AirlineDelayRating { get; set; }
    }
}
