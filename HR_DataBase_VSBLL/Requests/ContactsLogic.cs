using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using System.Collections.Generic;
using System.Linq;

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
            contactsDTO = MapModelToDTO(contactsModel);
            dapper.UpdateNewContact(contactsDTO, Id);
            contactsModel = MapDTOToModel(contactsDTO);

            return contactsModel;
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
            .ForMember(dest => dest.id, option => option.MapFrom(source => source.id))
            .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
            .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            contactsModel = mapper.Map<Contacts>(contactsDTO);
            return contactsModel;
        }

        private List<Contacts> MapListDTOToListModel(List<ContactsDTO> ContactsDTO)
        {
            List<Contacts> tmp = new List<Contacts>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<LocationDTO, Location>()
                .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
                .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
                .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
                .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber)));

            Mapper mapper = new Mapper(config);

            tmp = mapper.Map<List<Contacts>>(ContactsDTO);
            return tmp;
        }
    }
}
