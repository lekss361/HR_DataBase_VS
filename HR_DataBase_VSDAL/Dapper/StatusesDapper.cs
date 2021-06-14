using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class StatusesDapper
    {
        int ID;
        string _Query;
        string _Value;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="statusesDTO"></param>
        /// <returns></returns>
        public int AddNewStatuses(StatusesDTO statusesDTO)
        {
            _Query = "exec [HR_DataBase_VSDB].[AddNewStatuses]";
            _Value =
               $" N'{statusesDTO.Name}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.QueryFirst<int>(@$"{_Query}{_Value}");
            }
        }
    }
}
