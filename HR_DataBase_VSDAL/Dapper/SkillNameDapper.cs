using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;


namespace HR_DataBase_VSDAL.Dapper
{
    public class SkillNameDapper
    {
        int ID;

        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="SkillNameDTO"></param>
        /// <returns></returns>
        public int AddNewSkillName(SkillNameDTO SkillNameDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

            string tmp1 = "exec [HR_DataBase_VSDB].[AddNewSkillName]";
            string tmp2 = $" N'{SkillNameDTO.Skill}', N'{SkillNameDTO.SkillTypeID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ID = connection.QueryFirst<int>(@$"{tmp1}{tmp2}");
            }
            return ID;
        }
    }
}
