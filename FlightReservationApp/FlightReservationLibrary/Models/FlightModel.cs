using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationLibrary.Models
{
    public class FlightModel
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public string OriginAirport { get; set; }
        public string DestinationAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public double TripDuration { get; set; }
        public decimal Cost { get; set; }
        public AircaftModel Aircaft { get; set; }
        public int BusinessClassSeats { get; set; }
        public int EconomyClassSeats { get; set; }
    }
}
