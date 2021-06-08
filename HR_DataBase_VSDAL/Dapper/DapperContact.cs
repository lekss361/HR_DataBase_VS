using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;
using System.Data;

namespace HR_DataBase_VSDAL.Dapper
{
    public class DapperContact
    {
        ContactsDTO contactsDTO;
        List<ContactsDTO> listDTO = new List<ContactsDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Делаем запись в БД через хранимую процедуру
        /// </summary>
        /// <param name="locationDTO"></param>
        public void AddNewContact(ContactsDTO contactsDTO)
        {
            string query = "exec [HR_DataBase_VSDB].[AddContacts]";
            string value =
                $"N'{contactsDTO.Phone}', " +
                $"N'{contactsDTO.Email}', " +
                $"N'{contactsDTO.Information}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Query<ContactsDTO>(@$"{query}{value}");
            }
        }

        /// <summary>
        /// Находим запись по ID
        /// </summary>
        /// <returns>DTO записи из БД</returns>
        public ContactsDTO GetContactByID(int id)
        {
            string query = "exec [HR_DataBase_VSDB].[GetLocationByID]";
            string value =
                $"N'{id}'";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                contactsDTO = connection
                    .QueryFirst<ContactsDTO>(@$"{query}{value}");
            }
            return contactsDTO;
        }

        /// <summary>
        /// Достаём все записи из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List DTO записи из БД</returns>
        public List<ContactsDTO> GetAllContacts()
        {
            string query = "exec [HR_DataBase_VSDB].[GetAllLocations]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                listDTO = connection
                    .Query<ContactsDTO>(@$"{query}")
                    .AsList<ContactsDTO>();
            }
            return listDTO;
        }
    }
}
