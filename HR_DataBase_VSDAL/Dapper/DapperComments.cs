using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperComments
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        CommentsDTO commentsDTO;

        List<CommentsDTO> ListDTO = new List<CommentsDTO>();

        public void AddNewComments(CommentsDTO commentsDTO)
        {
            string query = "exec [HR_DataBase_VSDB].[AddNewComments]";
            string value =
                $"N'{commentsDTO.WorkersID}', " +
                $"N'{commentsDTO.Comment}', " +
                $"N'{commentsDTO.Date}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<CommentsDTO>(@$"{query}{value}");
            }
        }
        /// <summary>    
        /// Находим запись по ID
        /// </summary>
        /// <returns>DTO записи из БД</returns>
        public CommentsDTO GetAllCommentsByWorkersID(int id)
        {
            string query = "exec [HR_DataBase_VSDB].[GetAllCommentsByWorkersID]";
            string value =
                $"N'{id}'";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                commentsDTO = connection
                    .QueryFirst<CommentsDTO>(@$"{query}{value}");
            }
            return commentsDTO;
        }

        /// <summary>
        /// Достаём все записи из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List DTO записи из БД</returns>
        public List<CommentsDTO> GetAllProjects()
        {
            string query = "exec [HR_DataBase_VSDB].[GetAllProjects]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<CommentsDTO>(@$"{query}")
                    .AsList<CommentsDTO>();
            }
            return ListDTO;
        }
    }
}
