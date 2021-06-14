using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class ContactsLogic
    {
        private ContactsDTO contactsDTO = new ContactsDTO();
        private DapperContact dapper = new DapperContact();
        private MappersController mappersController = new MappersController();

        public Contacts GetContactsByID(int ID)
        {
            contactsDTO = dapper.GetContactByID(ID);
            return mappersController.MapContactsDTOToModel(contactsDTO);
        }

        public int AddContacts(Contacts contact)
        {
            contactsDTO = mappersController.MapContactsModelToDTO(contact);
            return dapper.AddNewContact(contactsDTO);
        }

        public Contacts UpdateContacts(Contacts contact, int Id)
        {
            contactsDTO = mappersController.MapContactsModelToDTO(contact);
            dapper.UpdateNewContact(contactsDTO, Id);
            contact = mappersController.MapContactsDTOToModel(contactsDTO);
            return contact;
        }
    }
}
