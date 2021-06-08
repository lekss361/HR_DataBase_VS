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
    public class MapperDivisions
    {
        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="divisions"></param>
        public DivisionsDTO MapToDivisionsDTO(Divisions divisions)
        {
            DivisionsDTO divisionsDTO = new DivisionsDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Divisions, DivisionsDTO>()

            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))
            .ForMember(dest => dest.CompanyID, option => option.MapFrom(source => source.CompanyID))
            .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))           
            .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID))
            .ForMember(dest => dest.DirectionsID, option => option.MapFrom(source => source.DirectionsID)));

            Mapper mapper = new Mapper(config);
            DivisionDapper dapper = new DivisionDapper();

            divisionsDTO = mapper.Map<DivisionsDTO>(divisions);
            dapper.AddNewDivision(divisionsDTO);
            return divisionsDTO;
        }
    }
}
