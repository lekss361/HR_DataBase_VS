using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class StatusesDapper
    {

        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="statusesDTO"></param>
        /// <returns></returns>
        public void AddNewStatuses(StatusesDTO statusesDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            string tmp1 = "exec [HR_DataBase_VSDB].[AddNewStatuses]";
            string tmp2 =
                $" N'{statusesDTO.Name}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<StatusesDTO>(@$"{tmp1}{tmp2}");
            }
        }
    }
}
