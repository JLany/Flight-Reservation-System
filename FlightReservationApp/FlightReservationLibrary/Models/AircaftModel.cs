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
        

        // i have to think of better names for these two
        public string PartialModelData
        {
            get => $"{ModelName} - {NumberOfSeats} Seats";
        }

        public string FullModelData
        {
            get => $"{Id} - {SerialNumber} - {ModelName} - {NumberOfSeats} Seats";
        }
    }

}
