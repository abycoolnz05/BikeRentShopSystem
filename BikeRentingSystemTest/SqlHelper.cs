using System.Data.SqlClient;
using System.Data;

namespace BikeRentingSystemTest
{
    public class SqlHelper
    {

        private IDbConnection Connection { get; set; }
        public ConnectionState State => this.Connection.State;

        /// <summary>
        /// Create SqlHelper with connection string.
        /// </summary>
        /// <param name="connectionString">Connection String</param>
        public SqlHelper(string connectionString)
        {
            this.Connection = new SqlConnection(connectionString);
        }
        public void Open() => this.Connection.Open();
    }
}
