using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using HR_DataBase_VSDAL.Models;
using System.Data;
using System;

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
        /// <param name="contactsDTO"></param>
        public int AddNewContact(ContactsDTO contactsDTO)
        {
            string query = "exec [HR_DataBase_VSDB].[AddContacts]";
            string value =
                $"N'{contactsDTO.Phone}', " +
                $"N'{contactsDTO.Email}', " +
                $"N'{contactsDTO.Information}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                contactsDTO.Id = connection.QueryFirst<int>(@$"{query}{value}");
            }
            return contactsDTO.Id;
        }

        /// <summary>
        /// Находим запись по ID
        /// </summary>
        /// <returns>DTO записи из БД</returns>
        public ContactsDTO GetContactByID(int ContactsId)
        {
            string query = "exec [HR_DataBase_VSDB].[GetContactsByID]";
            string value =
                $"N'{ContactsId}'";
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
            string query = "exec [HR_DataBase_VSDB].[GetAllContacts]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                listDTO = connection
                    .Query<ContactsDTO>(@$"{query}")
                    .AsList<ContactsDTO>();
            }
            return listDTO;
        }

        /// <summary>
        /// Изменяем запись в БД через хранимую процедуру
        /// </summary>
        /// <param name="contactsDTO"></param>
        public int UpdateNewContact(ContactsDTO contactsDTO)
        {
            ContactsDTO crntContactDTO = new ContactsDTO();
            //crntContactDTO = GetContactByID(contactsDTO.id);
            crntContactDTO = GetContactByID(2);

            string query = "exec [HR_DataBase_VSDB].[UpdateContactsByID]";
            string value =
                $"N'{contactsDTO.Id}', " +
                $"N'{contactsDTO.Phone}', " +
                $"N'{contactsDTO.Email}', " +
                $"N'{contactsDTO.Information}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    crntContactDTO = connection
                        .QueryFirst<ContactsDTO>(@$"{query}{value}", contactsDTO);
                }
                catch
                {
                    new Exception("Всё плохо");
                }
            }
            return crntContactDTO.Id;
        }

    }
}
