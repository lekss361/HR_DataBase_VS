﻿using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperWorker
    {
        int ID;
        string _Query;
        string _Value;

        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="workersDTO"></param>
        /// <returns></returns>
        public int AddNewWorker(WorkersDTO workersDTO)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
            _Query = "exec [HR_DataBase_VSDB].[AddWorker]";
            _Value =
               $"N'{workersDTO.FirstName}', " +
               $"N'{workersDTO.LastName}', " +
               $"N'{workersDTO.Patronymic}', " +
               $"N'{workersDTO.BirthDay}', " +
               $"N'{workersDTO.Education}', " +
               $"N'{workersDTO.Sex}', " +
               $"N'{workersDTO.StatusID}', " +
               $"N'{workersDTO.Hobby}', " +
               $"N'{workersDTO.ContactID}', " +
               $"N'{workersDTO.LocationID}', " +
               $"N'{workersDTO.PositionID}', " +
               $"N'{workersDTO.DivisionID}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ID = connection.QueryFirst<int>(@$"{_Query}{_Value}");
            }
            return ID;
        }
    }
}
