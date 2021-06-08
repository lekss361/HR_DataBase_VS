using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class MapperCompany
    {
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
    }
}
