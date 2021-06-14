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
    public class DirectionsLogic
    {
        MappersController mappersController = new MappersController();
        List<Directions> directions = new List<Directions>();
        DirectionsDTO directionsDTO = new DirectionsDTO();
        DirectionsDapper dapper = new DirectionsDapper();

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="directions"></param>
        public DirectionsDTO AddNewDirections(Directions directions)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Directions, DirectionsDTO>()
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name)));
            Mapper mapper = new Mapper(config);

            directionsDTO = mappersController.MapToDirectionsDTO(directions);
            dapper.AddNewDirections(directionsDTO);
            return directionsDTO;
        }

        public List<Directions> GetAllDirections()
        {
            List<DirectionsDTO> directionsDTO = dapper.GetAllDirections();
            List<Directions> directions = mappersController.MapToDirectionsModel(directionsDTO);
            return directions;
        }
    }
}
