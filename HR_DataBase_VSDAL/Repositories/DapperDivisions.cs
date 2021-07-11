using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using HR_DataBase_VSDAL.Models;


namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperDivision
    {
        DivisionWithForeignKeyValueDTO divisionWithForeignKeyValueDTO;
        string _Query;
        string _Value;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
        int ID;
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="divisionDTO"></param>
        /// <returns></returns>
        public int AddNewDivision(DivisionsDTO divisionsDTO)
        {
            string query = "exec [HR_DataBase_VSDB].[AddNewDivision]";
            string value =
                $" N'{divisionsDTO.Name}', N'{divisionsDTO.Information}', N'{divisionsDTO.CompanyID}', N'{divisionsDTO.ContactID}', N'{divisionsDTO.LocationID}', N'{divisionsDTO.DirectionsID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ID = connection.QueryFirst<int>(@$"{query}{value}");
            }
            return ID;
        }

        public DivisionWithForeignKeyValueDTO GetDivisionByID(int id)
        {
            string query = $"exec [HR_DataBase_VSDB].[GetDivisionByID] @ID={id}";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                divisionWithForeignKeyValueDTO = connection
                    .Query<DivisionWithForeignKeyValueDTO>(@$"{query}")
                    .First<DivisionWithForeignKeyValueDTO>();
            }
            return divisionWithForeignKeyValueDTO;
        }

        public int UpdateDivisoonsById(DivisionsDTO divisionsDTO, int id)
        {
            _Query = "exec [HR_DataBase_VSDB].[UpdateDivisionByID]";
            _Value =
               $"N'{id}', " +
               $"N'{divisionsDTO.Name}', " +
               $"N'{divisionsDTO.Information}', " +
               $"N'{divisionsDTO.CompanyID}', " +
               $"N'{divisionsDTO.ContactID}', " +
               $"N'{divisionsDTO.LocationID}', " +
               $"N'{divisionsDTO.DirectionsID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ID = connection.QueryFirstOrDefault<int>(@$"{_Query}{_Value}");
            }
            return ID;
        }

    }
}
