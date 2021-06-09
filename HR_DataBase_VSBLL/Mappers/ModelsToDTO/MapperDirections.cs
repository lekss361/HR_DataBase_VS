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
    public class MapperDirections
    {
        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="directions"></param>
        public DirectionsDTO MapToDirectionsDTO(Directions directions)
        {
            DirectionsDTO directionsDTO = new DirectionsDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Directions, DirectionsDTO>()

            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name)));


            Mapper mapper = new Mapper(config);
            DirectionsDapper dapper = new DirectionsDapper();

            directionsDTO = mapper.Map<DirectionsDTO>(directions);
            dapper.AddNewDirections(directionsDTO);
            return directionsDTO;
        }
    }
}
