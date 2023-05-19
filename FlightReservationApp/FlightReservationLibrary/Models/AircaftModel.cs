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
        public string SerialNumber { get; set; }
        public string ModelName { get; set; }
        public int NumberOfSeats { get; set; } 
        public string ModelData
        {
            get => $"{ModelName} - {NumberOfSeats} Seats";
        }
    }

}
