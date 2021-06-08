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
    public class DapperWorker
    {
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="workersDTO"></param>
        /// <returns></returns>
        public void AddNewWorker(WorkersDTO workersDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            string tmp1 = "exec [HR_DataBase_VSDB].[AddWorker]";
            string tmp2 =
                $" N'{workersDTO.FirstName}', N'{workersDTO.LastName}', '{workersDTO.BirthDay}', N'{workersDTO.Education}', N'{workersDTO.Sex}', N'{workersDTO.Hobby}', N'{workersDTO.ContactID}', N'{workersDTO.LocationID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<WorkersDTO>(@$"{tmp1}{tmp2}");
            }
        }
    }
}
