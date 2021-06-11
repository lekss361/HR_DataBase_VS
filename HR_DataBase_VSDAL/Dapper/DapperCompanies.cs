﻿using System;
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
        //CompaniesDTO companiesDTO;
        List<CompaniesDTO> ListDTO = new List<CompaniesDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="companiesDTO"></param>
        /// <returns></returns>

        public void AddNewCompany(CompaniesDTO companiesDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            string tmp1 = "exec [HR_DataBase_VSDB].[AddNewCompany]";
            string tmp2 =
                $" N'{companiesDTO.Name}', N'{companiesDTO.Information}', N'{companiesDTO.ContactID}', N'{companiesDTO.LocationID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<CompaniesDTO>(@$"{tmp1}{tmp2}");
            }
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
            string tmp1 = "exec [HR_DataBase_VSDB].[GetAllCompanies]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ListDTO = connection
                    .Query<CompaniesDTO>(@$"{tmp1}")
                    .AsList<CompaniesDTO>();
            }
            return ListDTO;
        }
    }
}
