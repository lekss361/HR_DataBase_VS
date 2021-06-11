using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HR_DataBase_VSDAL.DTO;
using HR_DataBase_VSDAL.Models;


namespace HR_DataBase_VSDAL.Dapper
{
    public class SkillNameDapper
    {
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="SkillNameDTO"></param>
        /// <returns></returns>
        public void AddNewSkillName(SkillNameDTO SkillNameDTO)
        {
            
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

            string query = "exec [HR_DataBase_VSDB].[AddNewSkillName]";
            string value = $" N'{SkillNameDTO.Skill}', N'{SkillNameDTO.SkillTypeID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<SkillNameDTO>(@$"{query}{value}");
            }
        }



        //public void GetSkillNameByTypeID(int idSkillType)
        //{
        //    string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        //    string query = "exec [HR_DataBase_VSDB].[GetSkillNameBySkillTypeID]";
        //    string value = $" N'{idSkillType}'";

        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Query<SkillNameByIdDTO>(@$"{query}{value}");
        //    }

        //}


        List<SkillNameByIdDTO> ListSkilNameDTO = new List<SkillNameByIdDTO>();

        public List<SkillNameByIdDTO> GetSkillNameByTypeID(int idSkillType)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

            string query = "exec [HR_DataBase_VSDB].[GetSkillNameBySkillTypeID]";
            string value = $" N'{idSkillType}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListSkilNameDTO = connection
                    .Query<SkillNameByIdDTO>($@"{query}{value}")
                    .AsList<SkillNameByIdDTO>();
            }
            return ListSkilNameDTO;


        }
    }
}
