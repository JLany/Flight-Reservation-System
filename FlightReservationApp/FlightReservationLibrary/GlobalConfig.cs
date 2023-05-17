using FlightReservationLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationLibrary
{
    public static class GlobalConfig
    {
        public static SqlServerConnector Connector { get; set; }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static void InitializeConnector()
        {
            Connector = new SqlServerConnector();
        }
    }
}
