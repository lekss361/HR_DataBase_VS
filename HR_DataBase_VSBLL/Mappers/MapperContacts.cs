using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class MapperContacts
    {
        ContactsDTO contactsDTO = new ContactsDTO();
        DapperContact dapper = new DapperContact();

        /// <summary>
        /// поиск данных по ID
        /// </summary>
        /// <param name="ID">ID записи</param>
        /// <returns>DTO записи из БД</returns>
        public ContactsDTO GetByID(int ID)
        {
            contactsDTO = dapper.GetContactByID(ID);
            return contactsDTO;
        }

        /// <summary>
        /// Добавляем новую запись в БД
        /// </summary>
        /// <param name="model">Модель</param>
        public void AddNew(Contacts model)
        {
            contactsDTO = MapModelToDTO(model);
            dapper.AddNewContact(contactsDTO);
        }

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="model"></param>
        private ContactsDTO MapModelToDTO(Contacts model)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Contacts, ContactsDTO>()
            .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
            .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            contactsDTO = mapper.Map<ContactsDTO>(model);
            return contactsDTO;
        }

    }
}
