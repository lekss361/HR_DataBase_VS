using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HR_DataBase_VSDAL.Models;


namespace HR_DataBase_VSDAL.Dapper
{
    public class DirectionsDapper
    {
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="directionsDTO"></param>
        /// <returns></returns>
        public void AddNewDirections(DirectionsDTO directionsDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            string tmp1 = "exec [HR_DataBase_VSDB].[AddNewDirections]";
            string tmp2 =
                $" N'{directionsDTO.Name}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<DirectionsDTO>(@$"{tmp1}{tmp2}");
            }
        }
    }
}
