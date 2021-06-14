using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;

namespace HR_DataBase_VSBLL.Mappers
{
    public class CompanyLogic
    {
        CompaniesDTO companiesDTO = new CompaniesDTO();
        Company company = new Company();
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
        public List<Company> GetAllCompanies()
        {
            List<CompaniesDTO> companiesDTO = dapper.GetAllCompanies();
            List<Company> companies = MapCompaniesDTOToModelList(companiesDTO);
            return companies;

            //List<CompaniesDTO> companiesDTO = dapper.GetAllCompanies();
            //List<Company> companies = MapCompaniesDTOToModelList(companiesDTO);
            //return companies;
        }

        public List<CompaniesWithContactAndLocation> GetAllCompaniesWithContactAndLocation()
        {
            List<CompaniesWithContactAndLocationDTO> companiesDTO = dapper.GetCompaniesWithContactAndLocation();
            List<CompaniesWithContactAndLocation> companies = MapCompaniesDTOToModelListFull(companiesDTO);

            return companies;
        }

        public int UpdateCompanyByid(Company model, int id)
        {
            companiesDTO = MapModelToCompaniesDTO(model);
            id = dapper.UpdateCompanyByid(companiesDTO, id);
            return id;
        }

        private CompaniesDTO MapModelToCompaniesDTO(Company companies)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Company, CompaniesDTO>()
            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
            .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))
            .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID)));

            Mapper mapper = new Mapper(config);

            companiesDTO = mapper.Map<CompaniesDTO>(companies);
            return companiesDTO;
        }

        private List<Company> MapCompaniesDTOToModelList(List<CompaniesDTO> companiesDTO)
        {
            List<Company> companies = new List<Company>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CompaniesDTO, Company>()
                .ForMember(dest => dest.Id, option => option.MapFrom(source => source.Id))
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
                .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))
                .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID)));

            Mapper mapper = new Mapper(config);

            companies = mapper.Map<List<Company>>(companiesDTO);
            return companies;
        }

        private List<CompaniesWithContactAndLocation> MapCompaniesDTOToModelListFull(List<CompaniesWithContactAndLocationDTO> companiesWithContactAndLocationDTO)
        {
            List<CompaniesWithContactAndLocation> companies = new List<CompaniesWithContactAndLocation>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CompaniesWithContactAndLocationDTO,
                CompaniesWithContactAndLocation>()
                .ForMember(dest => dest.id, option => option.MapFrom(source => source.id))
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
                .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
                .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
                .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
                .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber)));

            Mapper mapper = new Mapper(config);
            companies = mapper.Map<List<CompaniesWithContactAndLocation>>(companiesWithContactAndLocationDTO);
            return companies;
        }

        private CompanyWithForeignKeyValue MapCompanyByIDDTOToModel(CompanyWithForeignKeyValueDTO companyByIDDTO)
        {
            CompanyWithForeignKeyValue sda = new CompanyWithForeignKeyValue();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<CompanyWithForeignKeyValueDTO, CompanyWithForeignKeyValue>()
                .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))
                .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID))
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