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
    public class MapperCompany
    {
        CompanyWithForeignKeyValue fullCompaniesWithContactAndLocationById = new CompanyWithForeignKeyValue();
        CompanyWithForeignKeyValueDTO fullCompaniesWithContactAndLocationByIdDTO = new CompanyWithForeignKeyValueDTO();
        CompanyDapper dapper =new CompanyDapper();

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="companies"></param>
        public CompaniesDTO MapToCompaniesDTO(Company companies)
        {
            CompaniesDTO companiesDTO = new CompaniesDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Company, CompaniesDTO>()

            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
            .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))
            .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID)));

            Mapper mapper = new Mapper(config);
            CompanyDapper dapper = new CompanyDapper();

            companiesDTO = mapper.Map<CompaniesDTO>(companies);
            dapper.AddNewCompany(companiesDTO);
            return companiesDTO;
        }



        public CompanyWithForeignKeyValue GetCompanyByID(int id)
        {
            fullCompaniesWithContactAndLocationByIdDTO = dapper.GetCompanyByID(id);
            fullCompaniesWithContactAndLocationById = MapCompanyByIDDTOToModel(fullCompaniesWithContactAndLocationByIdDTO);


            return fullCompaniesWithContactAndLocationById;
        }

        private CompanyWithForeignKeyValue MapCompanyByIDDTOToModel(CompanyWithForeignKeyValueDTO companyByIDDTO)
        {
            CompanyWithForeignKeyValue sda = new CompanyWithForeignKeyValue();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CompanyWithForeignKeyValueDTO, CompanyWithForeignKeyValue>()
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))              
                .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
                .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
                .ForMember(dest => dest.ContactInformation, option => option.MapFrom(source => source.ContactInformation))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
                .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
                .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber))
                .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
                .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex)));

            Mapper mapper = new Mapper(config);

            sda = mapper.Map<CompanyWithForeignKeyValue>(companyByIDDTO);
            return sda;
        }
    }
}
