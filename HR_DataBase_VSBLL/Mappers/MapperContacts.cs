using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class MapperContacts
    {
        int ID;
        ContactsDTO contactsDTO = new ContactsDTO();
        Contacts contactsModel = new Contacts();
        DapperContact dapper = new DapperContact();

        /// <summary>
        /// поиск данных по ID
        /// </summary>
        /// <param name="ID">ID записи</param>
        /// <returns>DTO записи из БД</returns>
        public Contacts GetByID(int ID)
        {
            contactsDTO = dapper.GetContactByID(ID);
            contactsModel = MapDTOToModel(contactsDTO);
            return contactsModel;
        }

        /// <summary>
        /// Добавляем новую запись в БД
        /// </summary>
        /// <param name="contactsModel">Модель</param>
        public int AddNew(Contacts contactsModel)
        {
            ContactsDTO DTO = new ContactsDTO();

            contactsDTO = MapModelToDTO(contactsModel);
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
            ContactsDTO tmpDTOold = new ContactsDTO();
            ContactsDTO tmpDTONew = new ContactsDTO();
            Contacts tmpModel = new Contacts();

            tmpDTONew = MapModelToDTO(contactsModel);
            dapper.UpdateNewContact(tmpDTONew, Id);
            tmpModel = MapDTOToModel(tmpDTONew);

            return tmpModel;
        }

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="modelContacts"></param>
        private ContactsDTO MapModelToDTO(Contacts modelContacts)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Contacts, ContactsDTO>()
            .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
            .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            contactsDTO = mapper.Map<ContactsDTO>(modelContacts);
            return contactsDTO;
        }

        private Contacts MapDTOToModel(ContactsDTO contactsDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ContactsDTO, Contacts>()
            .ForMember(dest => dest.Id, option => option.MapFrom(source => source.Id))
            .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
            .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            contactsModel = mapper.Map<Contacts>(contactsDTO);
            return contactsModel;
        }
    }
}
