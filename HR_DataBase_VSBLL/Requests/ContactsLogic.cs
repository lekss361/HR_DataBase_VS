using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using System.Collections.Generic;

namespace HR_DataBase_VSBLL.Mappers
{
    public class ContactsLogic
    {
        int ID;
        ContactsDTO contactsDTO = new ContactsDTO();
        Contacts contactsModel = new Contacts();
        DapperContact dapper = new DapperContact();
        List<ContactsDTO> ListDTOs = new List<ContactsDTO>();
        List<Contacts> ListModels = new List<Contacts>();
        MappersController mappersController = new MappersController();

        /// <summary>
        /// поиск данных по ID
        /// </summary>
        /// <param name="ID">ID записи</param>
        /// <returns>DTO записи из БД</returns>
        public Contacts GetByID(int ID)
        {
            contactsDTO = dapper.GetContactByID(ID);
            contactsModel = mappersController.MapContactsDTOToModel(contactsDTO);
            return contactsModel;
        }

        /// <summary>
        /// Добавляем новую запись в БД
        /// </summary>
        /// <param name="contactsModel">Модель</param>
        public int AddNew(Contacts contactsModel)
        {
            contactsDTO = mappersController.MapContactsModelToDTO(contactsModel);
            ID = dapper.AddNewContact(contactsDTO);
            return ID;
        }

        /// <summary>
        /// Изменяем запись Contacts в БД
        /// </summary>
        /// <param name="contactsModel">модель с новыми данными</param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Contacts UpdateContacts(Contacts contactsModel, int Id)
        {
            contactsDTO = mappersController.MapContactsModelToDTO(contactsModel);
            dapper.UpdateNewContact(contactsDTO, Id);
            contactsModel = mappersController.MapContactsDTOToModel(contactsDTO);
            return contactsModel;
        }
    }
}
