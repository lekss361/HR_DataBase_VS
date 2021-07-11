using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HR_DataBase_VSDAL.DTO;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperProjectMaps
    {
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
        private string _query;
        private string _value;

        public void AddNewProjectMaps(ProjectMapsDTO projectMapsDTO)
        {
            _query = "exec [HR_DataBase_VSDB].[AddNewProjectsMapByWorkerId]";
            _value =
                $"N'{projectMapsDTO.ProjectID}', " +
                $"N'{projectMapsDTO.WorkerID}'";

            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Query<int>(@$"{_query}{_value}");
            }
        }
    }
}
