using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;


namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperProjectsWithDirectionName
    {
        // ProjectsWithDirectionNameDTO projectsWithDirectionNameDTO;
        List<ProjectsWithDirectionNameDTO> ListDTO = new List<ProjectsWithDirectionNameDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Достаём все записи из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List DTO записи из БД</returns>
        public List<ProjectsWithDirectionNameDTO> GetProjectsWithDirectionName()
        {
            string tmp1 = "exec [HR_DataBase_VSDB].[GetProjectsWithDirectionName]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<ProjectsWithDirectionNameDTO>(@$"{tmp1}")
                    .AsList<ProjectsWithDirectionNameDTO>();
            }
            return ListDTO;
        }
    }
}
