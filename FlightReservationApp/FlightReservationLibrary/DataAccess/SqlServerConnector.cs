using Dapper;
using FlightReservationLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationLibrary.DataAccess
{
    // Methods naming convention: 
    // OperationTable_Criteria()
    // ex: GetFlight_ByName()


    public class SqlServerConnector
    {
        private const string dbName = "Flights";

        public bool AuthenticateUser(AuthenticationModel  authentication)
        {
            bool authenticated;

            using (IDbConnection connection = 
                new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(dbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@email", authentication.UserEmail);
                parameters.Add("@password", authentication.Password);

                authenticated = connection.ExecuteScalar<bool>(
                    "dbo.sp_global_authenticate_user", parameters, commandType: CommandType.StoredProcedure);
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

                parameters.Add("@email", email);

                emailExists = connection.ExecuteScalar<bool>(
                    "dbo.sp_customer_check_email_exists", parameters, commandType: CommandType.StoredProcedure);
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

                parameters.Add("@first_name", model.FirstName);
                parameters.Add("@middle_name", model.MiddleName);
                parameters.Add("@last_name", model.LastName);
                parameters.Add("@email", model.Email);
                parameters.Add("@passport_number", model.PassportNumber);
                parameters.Add("@phone_number", model.PhoneNumber);
                parameters.Add("@password", model.Password);
                parameters.Add("@customer_id", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // store, and aquire the new id
                connection.Execute("dbo.sp_customer_insert", parameters, commandType: CommandType.StoredProcedure);

                model.Id = parameters.Get<int>("customer_id");
            }

            // return new model
            return model;
        }

    }
}
