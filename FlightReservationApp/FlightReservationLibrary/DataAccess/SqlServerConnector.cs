using Dapper;
using FlightReservationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationLibrary.DataAccess
{
    // Methods naming convention: 
    // OperationTable_Criteria()
    // ex: GetFlight_ByName()


    public class SqlServerConnector
    {
        private readonly string dbName = "Flights";

        public bool AuthenticateUser(AuthenticationModel  authentication)
        {
            bool authenticated;

            using (IDbConnection connection = 
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Email", authentication.UserEmail);
                parameters.Add("@Password", authentication.Password);

                authenticated = connection.ExecuteScalar<bool>(
                    "dbo.spCustomer_Authenticate", parameters, commandType: CommandType.StoredProcedure);
            }

            return authenticated;
        }

        public bool CheckCustomer_EmailExists(string email)
        {
            bool emailExists;

            using (IDbConnection connection = 
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Email", email);

                emailExists = connection.ExecuteScalar<bool>(
                    "dbo.spCustomer_CheckEmailExists", parameters, commandType: CommandType.StoredProcedure);
            }

            return emailExists;
        }

        public bool CheckCustomer_AnotherEmailExists(CustomerModel customer, string newEmail)
        {
            bool emailExists;

            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@OldEmail", customer.Email);
                parameters.Add("@NewEmail", newEmail);

                emailExists = connection.ExecuteScalar<bool>(
                    "dbo.spCustomer_CheckAnotherEmailExists", parameters, commandType: CommandType.StoredProcedure);
            }

            return emailExists;
        }

        public bool CheckTicket_Exists(FlightTicketModel ticket)
        {
            bool ticketExists;

            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CustomerId", ticket.Passenger.Id);
                parameters.Add("@FlightId", ticket.Flight.Id);

                ticketExists = connection.ExecuteScalar<bool>(
                    "dbo.spFlightTicket_CheckExists", parameters, commandType: CommandType.StoredProcedure);
            }

            return ticketExists;
        }

        public CustomerModel CreateCustomer(CustomerModel model)
        {
            // open a connection
            using (IDbConnection connection = 
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", model.FirstName);
                parameters.Add("@MiddleName", model.MiddleName);
                parameters.Add("@LastName", model.LastName);
                parameters.Add("@Email", model.Email);
                parameters.Add("@PassportNumber", model.PassportNumber);
                parameters.Add("@PhoneNumber", model.PhoneNumber);
                parameters.Add("@Password", model.Password);
                parameters.Add("@Id", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // store, and aquire the new id
                connection.Execute("dbo.spCustomer_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("Id");
            }

            // return new model
            return model;
        }

        public FlightTicketModel CreateTicket(FlightTicketModel model)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@TicketNumber", model.TicketNumber);
                parameters.Add("@CustomerId", model.Passenger.Id);
                parameters.Add("@FlightId", model.Flight.Id);
                parameters.Add("@FlightClass", model.FlightClass);
                parameters.Add("@Id", null, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spFlightTicket_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("@Id");

                switch (model.FlightClass)
                {
                    case FlightClass.Business:
                        model.Flight.BusinessClassSeats--;
                        break;
                    case FlightClass.Economy:
                        model.Flight.EconomyClassSeats--;
                        break;
                }

                model.Flight = UpdateFlight(model.Flight, connection);
            }

            return model;
        }

        public CustomerModel GetCustomer_ByEmail(string email)
        {
            CustomerModel output;

            using (IDbConnection connection = 
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Email", email);

                output = connection.Query<CustomerModel>("dbo.spCustomer_GetByEmail", parameters
                    , commandType: CommandType.StoredProcedure).First();

            }

            return output;
        }

        public FlightModel GetFlight_ByTicket(FlightTicketModel ticket)
        {
            FlightModel flight;

            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FlightTicketId", ticket.Id);

                flight = connection.Query<FlightModel>("dbo.spFlight_GetByFlightTicketId"
                , parameters, commandType: CommandType.StoredProcedure).First();

                flight.Aircaft = connection.Query<AircaftModel>(
                    "SELECT a.*" +
                    " FROM Aircraft a" +
                    " INNER JOIN Flight f ON a.Id = f.AircraftId" +
                    " AND f.Id = @FlightId"
                    , new { FlightId = flight.Id }).First();
            }

            return flight;
        }

        public List<FlightModel> GetFlights_DateOriginDestination(FlightQuery query)
        {
            var output = new List<FlightModel>();

            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@StartDatetime", query.Date.Date);
                parameters.Add("@EndDatetime", query.Date.AddDays(7));
                parameters.Add("@OriginAirport", query.OriginAirport);
                parameters.Add("@DestinationAirport", query.DestinationAirport);

                output = connection.Query<FlightModel>("dbo.spFlight_GetByDateOriginDestination"
                    , parameters, commandType: CommandType.StoredProcedure).ToList();

                foreach (var flight in output)
                {
                    flight.Aircaft = GetAircraft_ByFlight(flight, connection);
                }
            }

            return output;
        }

        public List<FlightTicketModel> GetTickets_ByCustomer(CustomerModel customer)
        {
            var output = new List<FlightTicketModel>();

            using (IDbConnection connection = 
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CustomerId", customer.Id);

                output = connection.Query<FlightTicketModel>("dbo.spFlightTicket_GetByCustomerId"
                    , parameters, commandType: CommandType.StoredProcedure).ToList();


                foreach (var ticket in output)
                {
                    parameters = new DynamicParameters();
                    parameters.Add("@FlightTicketId", ticket.Id);

                    ticket.Flight = connection.Query<FlightModel>("dbo.spFlight_GetByFlightTicketId"
                    , parameters, commandType: CommandType.StoredProcedure).First();

                    ticket.Flight.Aircaft = GetAircraft_ByFlight(ticket.Flight, connection);

                    ticket.Passenger = customer;
                }
            }

            return output;
        }

        public List<string> Get_AllDestinations()
        {
            var output = new List<string>();

            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                output = connection.Query<string>("dbo.spFlight_GetAllDestinations"
                    , commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<string> Get_AllOrigins()
        {
            var output = new List<string>();

            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                output = connection.Query<string>("dbo.spFlight_GetAllOrigins"
                    , commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public CustomerModel UpdateCustomer(CustomerModel customer)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", customer.FirstName);
                parameters.Add("@MiddleName", customer.MiddleName);
                parameters.Add("@LastName", customer.LastName);
                parameters.Add("@Email", customer.Email);
                parameters.Add("@PassportNumber", customer.PassportNumber);
                parameters.Add("@PhoneNumber", customer.PhoneNumber);
                parameters.Add("@Password", customer.Password);

                connection.Execute("dbo.spCustomer_CheckAnotherEmailExists", parameters
                    , commandType: CommandType.StoredProcedure);
            }

            return customer;
        }
                        
        // utility
        private AircaftModel GetAircraft_ByFlight(FlightModel flight, IDbConnection connection)
        {
            AircaftModel aircraft;

            aircraft = connection.Query<AircaftModel>(
                "SELECT a.*" +
                " FROM Aircraft a" +
                " INNER JOIN Flight f ON a.Id = f.AircraftId" +
                " AND f.Id = @FlightId"
                , new { FlightId = flight.Id }).First();

            return aircraft;
        }

        private FlightModel UpdateFlight(FlightModel flight, IDbConnection connection)
        {
            connection.Execute(
                "UPDATE Flight" +
                " SET BusinessClassSeats = @BusinessClassSeats" +
                " WHERE Flight.Id = @FlightId"
                , new { BusinessClassSeats = flight.BusinessClassSeats, FlightId = flight.Id });

            return flight;
        }
    }
}
