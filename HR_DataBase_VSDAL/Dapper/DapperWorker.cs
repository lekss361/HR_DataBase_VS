using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperWorker
    {
        string _Query;
        string _Value;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
        List<WorkersDTO> WorkersDTOs = new List<WorkersDTO>();

        /// <summary>
        /// Делаем запись в Базу Данных через хранимую процедуру
        /// </summary>
        /// <param name="workersDTO"></param>
        /// <returns></returns>
        public int AddNewWorker(WorkersDTO workersDTO)
        {
            int Id;

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
                    Id = connection
                    .QueryFirst<int>(@$"{_Query}{_Value}");
            }
            return Id;
        }

        public List<WorkersDTO> SearchWorkerBySameParam(WorkersDTO worker)
        {
            _Query = "exec [HR_DataBase_VSDB].[GetWorkerBySameParams]";
            _Value =
               $"N'{worker.FirstName}', " +
               $"N'{worker.LastName}', " +
               $"N'{worker.Patronymic}', " +
               $"N'{worker.BirthDay}', " +
               $"N'{worker.Sex}', " +
               $"N'{worker.StatusID}', " +
               $"N'{worker.Education}', " +
               $"N'{worker.ContactID}', " +
               $"N'{worker.LocationID}', " +
               $"N'{worker.Hobby}', " +
               $"N'{worker.PositionID}', " +
               $"N'{worker.DivisionID}'";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                WorkersDTOs = connection
                    .Query<WorkersDTO>(@$"{_Query}{_Value}")
                    .AsList<WorkersDTO>();
            }
            return WorkersDTOs;
        }
    }
}