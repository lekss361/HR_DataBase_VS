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
    public class LocationDapper
    {
        LocationDTO locationDTO;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";


        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="locationDTO"></param>
        public void AddNewLocation(LocationDTO locationDTO)
        {
            string tmp1 = "exec [HR_DataBase_VSDB].[AddLocation]";
            string tmp2 =
                $"N'{locationDTO.LocationIndex}', " +
                $"N'{locationDTO.Country}', " +
                $"N'{locationDTO.City}', " +
                $"N'{locationDTO.Street}', " +
                $"N'{locationDTO.HouseNumber}', " +
                $"N'{locationDTO.ApartmentNumber}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<LocationDTO>(@$"{tmp1}{tmp2}");
            }
        }

        /// <summary>
        /// Находим запись по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>LocationDTO</returns>
        public LocationDTO GetLocationByID(int id)
        {
            string tmp1 = "exec [HR_DataBase_VSDB].[GetLocationByID]";
            string tmp2 =
                $"N'{locationDTO.ID = id}'";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                locationDTO = (LocationDTO)connection.Query<LocationDTO>(@$"{tmp1}{tmp2}");
            }
            return locationDTO;
        }
    }
}
