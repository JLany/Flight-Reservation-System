using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationLibrary.Models
{
    public class FlightTicketModel
    {
        public int Id { get; set; }
        public string TicketNumber { get; set; }
        public CustomerModel Passenger { get; set; }
        public FlightModel Flight { get; set; }
        public FlightClass FlightClass { get; set; }

        public string TicketSummary
        {
            get => $"{TicketNumber}  ({Flight.OriginAirport} - {Flight.DestinationAirport})";
        }
    }
}
