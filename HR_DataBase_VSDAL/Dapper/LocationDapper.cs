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
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="locationDTO"></param>
        /// <returns></returns>
        public void AddNewLocation(LocationDTO locationDTO)
        {
            //List<LocationDTO> locations = new List<LocationDTO>();
            SqlCommand command = new SqlCommand();

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=HR_DataBase_VSDB;Integrated Security=True";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Country", locationDTO.Country);
            command.Parameters.AddWithValue("@City", locationDTO.City);
            command.Parameters.AddWithValue("@Street", locationDTO.Street);
            command.Parameters.AddWithValue("@HouseNumber", locationDTO.HouseNumber);
            command.Parameters.AddWithValue("@ApartmentNumber", locationDTO.ApartmentNumber);

            command.CommandText = "exec AddLocation";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<LocationDTO>(command.CommandText);
            }
        }
    }
}
