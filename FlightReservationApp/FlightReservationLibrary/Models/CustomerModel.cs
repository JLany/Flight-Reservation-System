using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationLibrary.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Sex Sex { get; set; }
        public string PassportNumber { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName { get => $"{FirstName} {MiddleName} {LastName}"; }
    }
}
