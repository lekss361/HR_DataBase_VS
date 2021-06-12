using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class MapperPositionsWithDirectionName
    {
        PositionsWithDirectionName positionsWithDirectionNameDTO = new PositionsWithDirectionName();
        DapperPositionsWithDirectionName dapper = new DapperPositionsWithDirectionName();

        public List<PositionsWithDirectionName> GetAllPositionsWithDirectionName()
        {
            List<PositionsWithDirectionNameDTO> positionsWithDirectionNameDTODtos = dapper.GetPositionsWithDirectionName();
            List<PositionsWithDirectionName> positionsWithDirectionName = MapPositionsWithDirectionNameDTOToModelList(positionsWithDirectionNameDTODtos);
            positionsWithDirectionNameDTODtos.Clear();

            return positionsWithDirectionName;
        }

        private List<PositionsWithDirectionName> MapPositionsWithDirectionNameDTOToModelList(List<PositionsWithDirectionNameDTO> positionsWithDirectionNameDTODtos)
        {
            List<PositionsWithDirectionName> sda = new List<PositionsWithDirectionName>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PositionsWithDirectionNameDTO, PositionsWithDirectionName>()
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.DirectionName, option => option.MapFrom(source => source.DirectionName)));

            Mapper mapper = new Mapper(config);

            sda = mapper.Map<List<PositionsWithDirectionName>>(positionsWithDirectionNameDTODtos);
            return sda;
        }
    }
}
