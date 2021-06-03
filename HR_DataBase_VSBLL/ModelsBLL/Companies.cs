using System;
using System.Collections.Generic;
using System.Data;
using HR_DataBase_VSDAL.Models;
using Dapper;
using System.Data.SqlClient;


namespace HR_DataBase_VSBLL
{
    class Companies
    {
        public static List<CompaniesDTO> GetAllCompanies()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=HR_DataBase_VSDB;Integrated Security=True";
            string quary = "exec GetAllCompanies";
            List<CompaniesDTO> companies = new List<CompaniesDTO>();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                companies = connection.Query<CompaniesDTO>(quary).AsList<CompaniesDTO>();
            }
            return companies;
        }
    }
}
