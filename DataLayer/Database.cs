/*using System.Data.SqlClient;

namespace PametniSat.DataLayer
{
    public class Database
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PametniSatDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;";

            return new SqlConnection(connectionString);
        }
    }
}*/
using System.Data.SqlClient;

namespace PametniSat.DataLayer
{
    public class Database
    {
        private static string connectionString =
        @"Data Source=(localdb)\MSSQLLocalDB;
          Initial Catalog=PametniSatDB;
          Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}