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
        int ID;
        string _Query;
        string _Value;
        ContactsDTO contactsDTO;
        List<ContactsDTO> listDTO = new List<ContactsDTO>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// Делаем запись в БД через хранимую процедуру
        /// </summary>
        /// <param name="contactsDTO"></param>
        public int AddNewContact(ContactsDTO contactsDTO)
        {
            _Query = "exec [HR_DataBase_VSDB].[AddContacts]";
            _Value =
                $"N'{contactsDTO.Phone}', " +
                $"N'{contactsDTO.Email}', " +
                $"N'{contactsDTO.Information}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                ID = connection.QueryFirst<int>(@$"{_Query}{_Value}");
            }
            return ID;
        }

        /// <summary>
        /// Находим запись по ID
        /// </summary>
        /// <returns>DTO записи из БД</returns>
        public ContactsDTO GetContactByID(int ContactsId)
        {
            _Query = "exec [HR_DataBase_VSDB].[GetContactsByID]";
            _Value =
               $"N'{ContactsId}'";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                contactsDTO = connection
                    .QueryFirst<ContactsDTO>(@$"{_Query}{_Value}");
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
            _Query = "exec [HR_DataBase_VSDB].[GetAllContacts]";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                listDTO = connection
                    .Query<ContactsDTO>(@$"{_Query}")
                    .AsList<ContactsDTO>();
            }
            return listDTO;
        }

        /// <summary>
        /// Изменяем запись в БД через хранимую процедуру
        /// </summary>
        /// <param name="oldContactsDTO"></param>
        public int UpdateNewContact(ContactsDTO currentContactsDTO, int id)
        {
            _Query = "exec [HR_DataBase_VSDB].[UpdateContactsByID]";
            _Value =
               $"@id ='{id}', " +
               $"@Phone ='{currentContactsDTO.Phone}', " +
               $"@Email'={currentContactsDTO.Email}', " +
               $"@Information ='{currentContactsDTO.Information}'";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    currentContactsDTO = connection.QueryFirstOrDefault<ContactsDTO>(@$"{_Query}{_Value}", id);
                }
                catch
                {
                    new Exception("Всё плохо");
                }
            }
            return currentContactsDTO.id;
        }
    }
}
