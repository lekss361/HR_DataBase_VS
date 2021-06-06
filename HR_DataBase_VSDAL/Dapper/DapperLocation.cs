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
    public class DapperLocation
    {
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="locationDTO"></param>
        /// <returns></returns>
        public void AddNewLocation(LocationDTO locationDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            string tmp1= "exec [HR_DataBase_VSDB].[AddLocation]";
            string tmp2 =
                $" N'{locationDTO.LocationIndex}', N'{locationDTO.Country}', N'{locationDTO.City}', N'{locationDTO.Street}', N'{locationDTO.HouseNumber}', N'{locationDTO.ApartmentNumber}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<LocationDTO>(@$"{tmp1}{tmp2}");
            }
        }
    }
}
