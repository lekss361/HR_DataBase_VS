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
    public class CompanyDapper
    {
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="companiesDTO"></param>
        /// <returns></returns>
        public void AddNewCompany(CompaniesDTO companiesDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            string query = "exec [HR_DataBase_VSDB].[AddNewCompany]";
            string value =
                $" N'{companiesDTO.Name}', N'{companiesDTO.Information}', N'{companiesDTO.ContactID}', N'{companiesDTO.LocationID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<CompaniesDTO>(@$"{query}{value}");
            }
        }
    }
}
