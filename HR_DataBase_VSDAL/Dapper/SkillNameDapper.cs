using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
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
            //List<LocationDTO> locations = new List<LocationDTO>();
            SqlCommand command = new SqlCommand();

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=HR_DataBase_VSDB;Integrated Security=True";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SkillTypeID", SkillNameDTO.SkillTypeID);
            command.Parameters.AddWithValue("@Skill", SkillNameDTO.Skill);
            

            command.CommandText = "exec AddLocation";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<SkillNameDTO>(command.CommandText);
            }
        }
    }
}
