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
    public class DivisionDapper
    {
        DivisionWithForeignKeyValueDTO divisionWithForeignKeyValueDTO;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="divisionDTO"></param>
        /// <returns></returns>
        public void AddNewDivision(DivisionsDTO divisionsDTO)
        {
            string tmp1 = "exec [HR_DataBase_VSDB].[AddNewDivision]";
            string tmp2 =
                $" N'{divisionsDTO.Name}', N'{divisionsDTO.Information}', N'{divisionsDTO.CompanyID}', N'{divisionsDTO.ContactID}', N'{divisionsDTO.LocationID}', N'{divisionsDTO.DirectionsID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<DivisionsDTO>(@$"{tmp1}{tmp2}");
            }
        }
        public DivisionWithForeignKeyValueDTO GetDivisionByID(int id)
        {
            string tmp1 = $"exec [HR_DataBase_VSDB].[GetDivisionByID] @ID={id}";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                divisionWithForeignKeyValueDTO = connection
                    .Query<DivisionWithForeignKeyValueDTO>(@$"{tmp1}")
                    .First<DivisionWithForeignKeyValueDTO>();
            }
            return divisionWithForeignKeyValueDTO;


        }

    }
}
