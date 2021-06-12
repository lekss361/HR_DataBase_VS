using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.DTO;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperCompaniesWithContactAndLocation
    {
        List<CompaniesWithContactAndLocationDTO> ListDTO = new List<CompaniesWithContactAndLocationDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
        public List<CompaniesWithContactAndLocationDTO> GetCompaniesWithContactAndLocation()
        {
            string query = "exec [HR_DataBase_VSDB].[GetCompaniesWithContactAndLocation]";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<CompaniesWithContactAndLocationDTO>(@$"{query}")
                    .AsList<CompaniesWithContactAndLocationDTO>();
            }
            return ListDTO;
        }
    }
}
