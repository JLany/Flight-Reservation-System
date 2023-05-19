using Dapper;
using FlightReservationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
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

        public AircaftModel GetAircraft_ByFlight(FlightModel flight)
        {
            AircaftModel aircraft;

            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                aircraft = connection.Query<AircaftModel>(
                    "SELECT a.*" +
                    " FROM Aircraft a" +
                    " INNER JOIN Flight f ON a.Id = f.AircraftId" +
                    " AND f.Id = @FlightId"
                    , new { FlightId = flight.Id }).First();
            }

            return aircraft;
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

                    ticket.Flight.Aircaft = connection.Query<AircaftModel>(
                    "SELECT a.*" +
                    " FROM Aircraft a" +
                    " INNER JOIN Flight f ON a.Id = f.AircraftId" +
                    " AND f.Id = @FlightId"
                    , new { FlightId = ticket.Flight.Id }).First();

                    ticket.Passenger = customer;
                }
            }

            return output;
        }
    }
}
