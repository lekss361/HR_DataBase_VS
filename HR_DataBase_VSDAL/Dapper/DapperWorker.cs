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
    class DapperWorker
    {
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="workersDTO"></param>
        /// <returns></returns>
        public void AddNewLocation(WorkersDTO workersDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            string tmp1 = "exec [HR_DataBase_VSDB].[AddLocation]";
            string tmp2 =
                $" N'{workersDTO.BirthDay}', N'{workersDTO.Sex}', N'{workersDTO.ContactID}', N'{workersDTO.Education}', N'{workersDTO.FirstName}', N'{workersDTO.LastName}', N'{workersDTO.LocationID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<WorkersDTO>(@$"{tmp1}{tmp2}");
            }
        }
    }
}
