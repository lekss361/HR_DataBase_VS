using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperProjects
    {
        int ID;
        string _Query;
        string _Value;
        ProjectDTO projectDTO;
        List<ProjectDTO> ListDTO = new List<ProjectDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        public int AddNewProject(ProjectDTO projectDTO)
        {
            _Query = "exec [HR_DataBase_VSDB].[AddNewProject]";
            _Value =
               $"N'{projectDTO.Name}', " +
               $"N'{projectDTO.DirectionsID}', " +
               $"N'{projectDTO.Information}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ID = connection.QueryFirst<int>(@$"{_Query}{_Value}");
            }
            return ID;
        }

        /// <summary>    
        /// Находим запись по ID
        /// </summary>
        /// <returns>DTO записи из БД</returns>
        public ProjectDTO GetProjectByID(int id)
        {
            _Query = "exec [HR_DataBase_VSDB].[GetProjectByID]";
            _Value =
               $"N'{id}'";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                projectDTO = connection
                    .QueryFirst<ProjectDTO>(@$"{_Query}{_Value}");
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
            _Query = "exec [HR_DataBase_VSDB].[GetAllProjects]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<ProjectDTO>(@$"{_Query}")
                    .AsList<ProjectDTO>();
            }
            return ListDTO;
        }
    }
}
