using System.Configuration;
using System.Data.SqlClient;

namespace DentalClinicProject.Data
{
    /// <summary>
    /// Central helper that creates and returns an open SqlConnection
    /// using the connection string defined in App.config.
    /// Usage:
    ///   using (var conn = DbHelper.GetConnection())
    ///   {
    ///       // conn is already Open
    ///   }
    /// </summary>
    public static class DbHelper
    {
        // Key must match the 'name' attribute in App.config <connectionStrings>
        private const string ConnectionName = "DentalClinicDB";

        /// <summary>
        /// Returns an open SqlConnection. The caller is responsible for
        /// disposing it (use inside a using block).
        /// </summary>
        public static SqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
            var connection = new SqlConnection(connStr);
            connection.Open();
            return connection;
        }
    }
}
