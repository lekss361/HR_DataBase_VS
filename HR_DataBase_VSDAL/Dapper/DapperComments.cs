using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperComments
    {
        int _ID;
        string _Query;
        string _Value;
        CommentsDTO commentsDTO;
        List<CommentsDTO> ListDTO = new List<CommentsDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Добавляем новую запись
        /// </summary>
        /// <param name="commentsDTO"></param>
        public int AddNewComments(CommentsDTO commentsDTO)
        {
            _Query = "exec [HR_DataBase_VSDB].[AddNewComments]";
            _Value =
               $"N'{commentsDTO.WorkersID}', " +
               $"N'{commentsDTO.Comment}', " +
               $"N'{commentsDTO.Date}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                _ID = connection.QueryFirst<int>(@$"{_Query}{_Value}");
            }
            return _ID;
        }

        /// <summary>    
        /// Находим запись по ID
        /// </summary>
        /// <returns>DTO записи из БД</returns>
        public CommentsDTO GetAllCommentsByWorkersID(int id)
        {
            _Query = "exec [HR_DataBase_VSDB].[GetAllCommentsByWorkersID]";
            _Value =
               $"N'{id}'";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                commentsDTO = connection
                    .QueryFirst<CommentsDTO>(@$"{_Query}{_Value}");
            }
            return commentsDTO;
        }

        /// <summary>
        /// Достаём все записи из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List DTO записи из БД</returns>
        public List<CommentsDTO> GetAllComments()
        {
            _Query = "exec [HR_DataBase_VSDB].[GetAllComments]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<CommentsDTO>(@$"{_Query}")
                    .AsList<CommentsDTO>();
            }
            return ListDTO;
        }

        /// <summary>
        /// Изменяем запись в БД через хранимую процедуру
        /// </summary>
        /// <param name="currentCommentsDTO"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int UpdateNewContact(CommentsDTO currentCommentsDTO, int Id)
        {
            _Query = "exec [HR_DataBase_VSDB].[UpdateAllCommentsByID]";
            _Value =
               $"N'{Id}', " +
               $"N'{currentCommentsDTO.Comment}', " +
               $"N'{currentCommentsDTO.Date}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    currentCommentsDTO = connection.QueryFirst<CommentsDTO>(@$"{_Query}{_Value}", Id);
                }
                catch
                {
                    new Exception("Всё плохо");
                }
            }
            return currentCommentsDTO.WorkersID;
        }
    }
}
