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
    public class CompanyDapper
    {
        int _ID;
        string _Query;
        string _Value;
        CompaniesDTO companiesDTO;
        List<CompaniesDTO> ListDTO = new List<CompaniesDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="companiesDTO"></param>
        /// <returns></returns>
        public int AddNewCompany(CompaniesDTO companiesDTO)
        {
            _Query = "exec [HR_DataBase_VSDB].[AddNewCompany]";
            _Value =
               $" N'{companiesDTO.Name}', " +
               $"N'{companiesDTO.Information}', " +
               $"N'{companiesDTO.ContactID}', " +
               $"N'{companiesDTO.LocationID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                _ID = connection.QueryFirst<int>(@$"{_Query}{_Value}");
            }
            return _ID;
        }

        public List<CompaniesWithContactAndLocationDTO> GetCompaniesWithContactAndLocation()
        {
            List<CompaniesWithContactAndLocationDTO> listCompanies = new List<CompaniesWithContactAndLocationDTO>();
            string query = "exec [HR_DataBase_VSDB].[GetCompaniesWithContactAndLocation]";
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                listCompanies = connection

                    .Query<CompaniesWithContactAndLocationDTO>(@$"{query}")

                    .AsList<CompaniesWithContactAndLocationDTO>();

            }
            return listCompanies;
        }

        /// <summary>
        /// Находим запись по ID
        /// </summary>
        /// <returns>DTO записи из БД</returns>
        public List<CompaniesDTO> GetAllCompanies()
        {
            _Query = "exec [HR_DataBase_VSDB].[GetAllCompanies]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<CompaniesDTO>(@$"{_Query}")
                    .AsList<CompaniesDTO>();
            }
            return ListDTO;
        }

        public CompanyWithForeignKeyValueDTO GetCompanyByID(int id)
        {
            CompanyWithForeignKeyValueDTO fullCompaniesWithContactAndLocationByIdDTO = new CompanyWithForeignKeyValueDTO();
            string tmp1 = $"exec [HR_DataBase_VSDB].[CompanyWithForeignKeyValueById] @ID={id}";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                fullCompaniesWithContactAndLocationByIdDTO = connection
                    .Query<CompanyWithForeignKeyValueDTO>(@$"{tmp1}")
                    .First<CompanyWithForeignKeyValueDTO>();
            }
            return fullCompaniesWithContactAndLocationByIdDTO;
        }
    }
}