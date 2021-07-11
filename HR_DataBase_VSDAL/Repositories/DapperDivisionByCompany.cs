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
    public class DapperDivisionByCompany
    {
        List<DivisionByCompanyDTO> ListDTO = new List<DivisionByCompanyDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Достаём все записи из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List DTO записи из БД</returns>
        public List<DivisionByCompanyDTO> GetDivisionByCompanyID(int id)
        {
            string query = $"exec [HR_DataBase_VSDB].[GetDivisionByCompanyID] @CompanyID={id}";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<DivisionByCompanyDTO>(@$"{query}")
                    .AsList<DivisionByCompanyDTO>();
            }
            return ListDTO;
        }
    }
}