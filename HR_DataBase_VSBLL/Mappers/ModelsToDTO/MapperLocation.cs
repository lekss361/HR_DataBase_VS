using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class MapperLocation
    {
        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="location"></param>
        public LocationDTO MapToLocationDTO(Location location)
        {
            LocationDTO locationDTO = new LocationDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Location, LocationDTO>()
            .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
            .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
            .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
            .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
            .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber)));

            Mapper mapper = new Mapper(config);

            locationDTO = mapper.Map<LocationDTO>(location);
            return locationDTO;
        }
    }
}
