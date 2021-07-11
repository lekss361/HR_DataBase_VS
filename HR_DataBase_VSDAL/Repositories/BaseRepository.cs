using System.Data;
using System.Data.SqlClient;

namespace HR_DataBase_VSDAL.Repositories
{
    public abstract class BaseRepository
    {
        protected const string _connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;TrustServerCertificate=False";

        protected IDbConnection _connection;
        //aaa
        protected BaseRepository()
        {
            _connection = new SqlConnection(_connectionString);
        }
    }
}