using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.DTO;
using HR_DataBase_VSDAL.Models;


namespace HR_DataBase_VSDAL.Dapper
{
    public class SkillNameDapper
    {
        private List<SkillNameWithTypeDTO> skillNameWithTypeDTO = new List<SkillNameWithTypeDTO>();
        private string _query;
        private string _value;
        string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="SkillNameDTO"></param>
        /// <returns></returns>
        public int AddNewSkillName(SkillNameWithTypeDTO SkillNameDTO)
        {
            _query = "exec [HR_DataBase_VSDB].[AddNewSkillName]";
            _value = $" N'{SkillNameDTO.SkillName}', N'{SkillNameDTO.SkillType}'";
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirst<int>(@$"{_query}{_value}");
            }
        }

        public List<SkillNameWithTypeDTO> GetSkillNameByTypeId(int id)
        {
            _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            _query = $"exec [HR_DataBase_VSDB].[GetSkillNameBySkillTypeID] @SkillTypeID={id}";
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                skillNameWithTypeDTO = connection
                    .Query<SkillNameWithTypeDTO>($@"{_query}")
                    .AsList<SkillNameWithTypeDTO>();
            }
            return skillNameWithTypeDTO;
        }

        public List<SkillNameWithTypeDTO> GetSkillNameByAllType()
        {
            _query = "exec [HR_DataBase_VSDB].[GetAllSkillNames]";
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                skillNameWithTypeDTO = connection
                    .Query<SkillNameWithTypeDTO>($@"{_query}")
                    .AsList<SkillNameWithTypeDTO>();
            }
            return skillNameWithTypeDTO;
        }
    }
}
