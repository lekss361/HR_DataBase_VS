using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using System.Collections;


namespace HR_DataBase_VSBLL.Mappers
{
   public class DivisionByCompanyLogic
    {
        DapperDivisionByCompany dapper = new DapperDivisionByCompany();

        public List<DivisionByCompany> GetDivisionByCompanyID(int id)
        {
            List<DivisionByCompanyDTO> divisionByCompanyDTODtos = dapper.GetDivisionByCompanyID(id);
            List<DivisionByCompany> divisionByCompany = MapDivisionByCompanyDTOToModelList(divisionByCompanyDTODtos);
            divisionByCompanyDTODtos.Clear();

            return divisionByCompany;
        }

        private List<DivisionByCompany> MapDivisionByCompanyDTOToModelList(List<DivisionByCompanyDTO> divisionByCompanyDTODtos)
        {
            List<DivisionByCompany> sda = new List<DivisionByCompany>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<DivisionByCompanyDTO, DivisionByCompany>()
                .ForMember(dest => dest.id, option => option.MapFrom(source => source.id))
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.DirectionName, option => option.MapFrom(source => source.DirectionName))
                .ForMember(dest => dest.Phone, option => option.MapFrom(source => source.Phone))
                .ForMember(dest => dest.Email, option => option.MapFrom(source => source.Email))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City)));

            Mapper mapper = new Mapper(config);

            sda = mapper.Map<List<DivisionByCompany>>(divisionByCompanyDTODtos);
            return sda;
        }

    }
}
