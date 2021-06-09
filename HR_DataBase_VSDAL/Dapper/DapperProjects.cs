using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperProjects
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        ProjectDTO projectDTO;

        List<ProjectDTO> ListDTO = new List<ProjectDTO>();

        public void AddNewProject(ProjectDTO projectDTO)
        {
            string query = "exec [HR_DataBase_VSDB].[AddNewProject]";
            string value =
                $"N'{projectDTO.Name}', " +
                $"N'{projectDTO.DirectionsID}', " +
                $"N'{projectDTO.Information}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<ContactsDTO>(@$"{query}{value}");
            }
        }
        
        /// <summary>    
        /// Находим запись по ID
        /// </summary>
        /// <returns>DTO записи из БД</returns>
        public ProjectDTO GetProjectByID(int id)
        {
            string query = "exec [HR_DataBase_VSDB].[GetProjectByID]";
            string value =
                $"N'{id}'";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                projectDTO = connection
                    .QueryFirst<ProjectDTO>(@$"{query}{value}");
            }
            return projectDTO;
        }

        /// <summary>
        /// Достаём все записи из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List DTO записи из БД</returns>
        public List<ProjectDTO> GetAllProjects()
        {
            string query = "exec [HR_DataBase_VSDB].[GetAllProjects]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<ProjectDTO>(@$"{query}")
                    .AsList<ProjectDTO>();
            }
            return ListDTO;
        }
    }
}
