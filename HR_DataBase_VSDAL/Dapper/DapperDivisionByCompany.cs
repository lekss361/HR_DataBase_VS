using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperDivisionByCompany
    {
        string _Query;
        string _Value;
        List<DivisionByCompanyDTO> ListDTO = new List<DivisionByCompanyDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Достаём все записи из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List DTO записи из БД</returns>
        public List<DivisionByCompanyDTO> GetDivisionByCompanyID(int CompanyId)
        {
            _Query = $"exec [HR_DataBase_VSDB].[GetDivisionByCompanyID]";
            _Value =
                $"N'{CompanyId}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<DivisionByCompanyDTO>(@$"{_Query}")
                    .AsList<DivisionByCompanyDTO>();
            }
            return ListDTO;
        }
    }
}
