using FlightReservationLibrary.Models;

namespace FlightReservationUI.Communication
{
    public interface ITicketRequester
    {
        void TicketResponse(FlightTicketModel ticket);
    }
}
