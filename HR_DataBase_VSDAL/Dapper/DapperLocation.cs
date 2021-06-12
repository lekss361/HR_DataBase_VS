using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;


namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperLocation
    {
        int ID;
        string _Query;
        string _Value;
        LocationDTO locationDTO;
        List<LocationDTO> ListDTO = new List<LocationDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";


        /// <summary>
        /// Делаем запись в БД через хранимую процедуру
        /// </summary>
        /// <param name="locationDTO"></param>
        public int AddNewLocation(LocationDTO locationDTO)
        {
            _Query = "exec [HR_DataBase_VSDB].[AddLocation]";
            _Value =
               $"N'{locationDTO.LocationIndex}', " +
               $"N'{locationDTO.Country}', " +
               $"N'{locationDTO.City}', " +
               $"N'{locationDTO.Street}', " +
               $"N'{locationDTO.HouseNumber}', " +
               $"N'{locationDTO.ApartmentNumber}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ID = connection.QueryFirst<int>(@$"{_Query}{_Value}");
            }
            return ID;
        }

        /// <summary>
        /// Находим запись по ID
        /// </summary>
        /// <returns>DTO записи из БД</returns>
        public LocationDTO GetLocationByID(int locationId)
        {
            _Query = "exec [HR_DataBase_VSDB].[GetLocationByID]";
            _Value =
               $"N'{locationId}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                locationDTO = connection
                    .QueryFirst<LocationDTO>(@$"{_Query}{_Value}");
            }
            return locationDTO;
        }

        /// <summary>
        /// Достаём все записи из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List DTO записи из БД</returns>
        public List<LocationDTO> GetAllLocation()
        {
            _Query = "exec [HR_DataBase_VSDB].[GetAllLocations]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<LocationDTO>(@$"{_Query}")
                    .AsList<LocationDTO>();
            }
            return ListDTO;
        }
    }
}
