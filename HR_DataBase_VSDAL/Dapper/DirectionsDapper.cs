using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;


namespace HR_DataBase_VSDAL.Dapper
{
    public class DirectionsDapper
    {
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
        private string _query;
        private string _value;
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="directionsDTO"></param>
        /// <returns></returns>
        public void AddNewDirections(DirectionsDTO directionsDTO)
        {
            _query = "exec [HR_DataBase_VSDB].[AddNewDirections]";
            _value =
                $" N'{directionsDTO.Name}'";

            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Query<int>(@$"{_query}{_value}");
            }
        }

        public List<DirectionsDTO> GetAllDirections()
        {
            List<DirectionsDTO> ListDTO = new List<DirectionsDTO>();
            _query = "exec [HR_DataBase_VSDB].[GetAllDirections]";
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                ListDTO = connection
                    .Query<DirectionsDTO>(@$"{_query}")
                    .AsList<DirectionsDTO>();
            }
            return ListDTO;
        }
    }
}
