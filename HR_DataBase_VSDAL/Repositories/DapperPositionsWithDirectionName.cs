using HR_DataBase_VSDAL.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperPositionsWithDirectionName
    {
        List<PositionsWithDirectionNameDTO> ListPositionDTO = new List<PositionsWithDirectionNameDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Достаём все записи из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ListPositionDTO записи из БД</returns>
        public List<PositionsWithDirectionNameDTO> GetPositionsWithDirectionName()
        {
            string _Query = "exec [HR_DataBase_VSDB].[GetPositionsWithDirectionName]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListPositionDTO = connection
                    .Query<PositionsWithDirectionNameDTO>($@"{_Query}")
                    .AsList<PositionsWithDirectionNameDTO>();
            }
            return ListPositionDTO;
        }
    }
}
