using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationLibrary.Models
{
    public class FlightQuery
    {
        public DateTime Date { get; set; }
        public string OriginAirport { get; set; }
        public string DestinationAirport { get; set;}
    }
}
