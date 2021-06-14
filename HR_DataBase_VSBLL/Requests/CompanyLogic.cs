using System.Collections.Generic;
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
        CompanyDapper dapper = new CompanyDapper();
        MappersController mappersController = new MappersController();

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="companies"></param>
        public CompaniesDTO AddNewCompany(Company companies)
        {
            companiesDTO = mappersController.MapCompaniesModelToDTO(companies);
            dapper.AddNewCompany(companiesDTO);
            return companiesDTO;
        }

        public CompanyWithForeignKeyValue GetCompanyByID(int id)
        {
            fullCompaniesWithContactAndLocationByIdDTO = dapper.GetCompanyByID(id);
            fullCompaniesWithContactAndLocationById = mappersController.MapCompanyWithForeignKeyValueDTOToModel(fullCompaniesWithContactAndLocationByIdDTO);
            return fullCompaniesWithContactAndLocationById;
        }

        public List<Company> GetAllCompanies()
        {
            List<CompaniesDTO> companiesDTO = dapper.GetAllCompanies();
            List<Company> companies = mappersController.MapCompaniesDTOToModel(companiesDTO);
            return companies;
        }

        public List<CompaniesWithContactAndLocation> GetAllCompaniesWithContactAndLocation()
        {
            List<CompaniesWithContactAndLocationDTO> companiesDTO = dapper.GetCompaniesWithContactAndLocation();
            List<CompaniesWithContactAndLocation> companies = mappersController.MapCompaniesWithContactAndLocationDTODTOToModel(companiesDTO);
            return companies;
        }

        public int UpdateCompanyByid(Company model, int id)
        {
            companiesDTO = mappersController.MapModelToCompaniesDTO(model);
            id = dapper.UpdateCompanyByid(companiesDTO, id);
            return id;
        }
    }
}