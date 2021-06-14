using System.Collections.Generic;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;

namespace HR_DataBase_VSBLL.Mappers
{
    public class CompanyLogic
    {
        private CompaniesDTO companiesDTO = new CompaniesDTO();
        private CompanyWithForeignKeyValue companyWhisKey = new CompanyWithForeignKeyValue();
        private CompanyWithForeignKeyValueDTO companyWhisKeyDTO = new CompanyWithForeignKeyValueDTO();
        private CompanyDapper dapper = new CompanyDapper();
        private MappersController mappersController = new MappersController();

        public int AddNewCompany(Company company)
        {
            companiesDTO = mappersController.MapCompaniesModelToDTO(company);
            return dapper.AddNewCompany(companiesDTO);
        }

        public CompanyWithForeignKeyValue GetCompanyByID(int id)
        {
            companyWhisKeyDTO = dapper.GetCompanyByID(id);
            companyWhisKey = mappersController
                .MapCompanyWithForeignKeyValueDTOToModel(companyWhisKeyDTO);
            return companyWhisKey;
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
            companiesDTO = mappersController.MapCompaniesModelToDTO(model);
            return dapper.UpdateCompanyByid(companiesDTO, id);
        }
    }
}