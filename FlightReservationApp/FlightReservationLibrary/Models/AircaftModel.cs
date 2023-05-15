using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationLibrary.Models
{
    public class AircaftModel
    {
        public int Id { get; set; }
        public string SerialNo { get; set; }
        public string ModelName { get; set; }
        public int NumberOfSeats { get; set; } 
    }
}
