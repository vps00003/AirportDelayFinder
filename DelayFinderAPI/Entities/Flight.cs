namespace DelayFinderAPI.Entities
{
    public class Flight
    {
        public int FlightID { get; set; }
        public string AirlineID { get; set; }
        public string DepartureAirportID { get; set; }
        public string DestinationAirportID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int? FlightDelayMinutes { get; set; }
    }

}
