using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HR_DataBase_VSDAL.DTO;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class PreviousWorkDapper
    {
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="previousJobDTO"></param>
        /// <returns></returns>
        public void AddPreviousWork(PreviousWorkDTO previousJobDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            string query = "exec [HR_DataBase_VSDB].[AddNewPreviousWork]";
            string value =
                $"N'{previousJobDTO.WorkerID}', " +
                $"N'{previousJobDTO.StartDate}', " +
                $"N'{previousJobDTO.EndDate}', " +
                $"N'{previousJobDTO.Information}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<PreviousWorkDTO>(@$"{query}{value}");
            }
        }

    }
}
