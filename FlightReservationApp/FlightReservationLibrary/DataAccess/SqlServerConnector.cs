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

        public bool AuthenticateUser(AuthenticationModel authentication)
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

        public AircaftModel CreateAircraft(AircaftModel model)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@SerialNumber", model.SerialNumber);
                parameters.Add("@ModelName", model.ModelName);
                parameters.Add("@NumberOfSeats", model.NumberOfSeats);

                parameters.Add("@Id", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAircraft_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("Id");
            }

            return model;
        }

        public FlightModel CreateFlight(FlightModel model)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@FlightNumber", model.FlightNumber);
                parameters.Add("@OriginAirport", model.OriginAirport);
                parameters.Add("@DestinationAirport", model.DestinationAirport);
                parameters.Add("@DepartureTime", model.DepartureTime);
                parameters.Add("@ArrivalTime", model.ArrivalTime);
                parameters.Add("@TripDuration", model.TripDuration);
                parameters.Add("@Cost", model.Cost);
                parameters.Add("@AircraftId", model.Aircaft.Id);
                parameters.Add("@BusinessClassSeats", model.BusinessClassSeats);
                parameters.Add("@EconomyClassSeats", model.EconomyClassSeats);

                parameters.Add("@Id", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // store, and aquire the new id
                connection.Execute("dbo.spFlight_Insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("Id");
            }

            // return new model
            return model;
        }

        public List<AircaftModel> GetAircafts_ByDate(DateTime departureTime, DateTime arrivalTime)
        {
            List<AircaftModel> availableAircrafts = new List<AircaftModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@DepartureTime", departureTime);
                parameters.Add("@ArrivalTime", arrivalTime);

                availableAircrafts = connection.Query<AircaftModel>(
                    "dbo.spAircraft_GetByDate",
                    parameters,
                    commandType: CommandType.StoredProcedure).ToList();
            }

            return availableAircrafts;

        }

        public List<AircaftModel> GetAllAircrafts()
        {
            List<AircaftModel> Aircrafts = new List<AircaftModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                Aircrafts =
                    connection.Query<AircaftModel>("SELECT * FROM Aircraft").ToList();
            }

            return Aircrafts;
        }

        public void UpdateAircraft(AircaftModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Id", model.Id);
                parameters.Add("@SerialNumber", model.SerialNumber);
                parameters.Add("@ModelName", model.ModelName);
                parameters.Add("@NumberOfSeats", model.NumberOfSeats);

                connection.Execute("dbo.spAircraft_Update", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteAircraft_ById(int aircraftId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                connection.Execute($"Delete FROM Aircraft WHERE Id = {aircraftId}");
            }
        }

        public List<FlightModel> GetAllFlights()
        {
            var Flights = new List<FlightModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                Flights =
                    connection.Query<FlightModel>("SELECT * FROM Flight").ToList();
            }

            return Flights;
        }

        public void UpdateFlightDate_ByID(DateTime departureTime, DateTime arrivalTime, int flightID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id", flightID);
                parameters.Add("@DepartureTime", departureTime);
                parameters.Add("@ArrivalTime", arrivalTime);

                connection.Execute("dbo.spFlight_UpdateDate", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteFlight_ById(int flightId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                connection.Execute($"Delete FROM Flight WHERE Id = {flightId}");
            }
        }

    }
}
