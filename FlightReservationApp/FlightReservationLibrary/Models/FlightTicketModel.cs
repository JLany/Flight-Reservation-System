﻿using System;
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
        public FlightClass Class { get; set; }
        public string SeatNumber { get; set; }
    }
}