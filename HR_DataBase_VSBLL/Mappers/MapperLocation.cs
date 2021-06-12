using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class MapperLocation
    {
        LocationDTO locationDTO = new LocationDTO();
        Location location = new Location();
        DapperLocation dapper = new DapperLocation();
        //List<LocationDTO> locationDtos = new List<LocationDTO>();
        //List<Location> locations = new List<Location>();

        /// <summary>
        /// поиск Location по ID
        /// </summary>
        /// <param name="ID">LocationID</param>
        /// <returns>LocationDTO</returns>
        public Location GetLocationByID1(int ID)
        {
            locationDTO = dapper.GetLocationByID(ID);
            return MapLocationDTOToModel(locationDTO);
        }

        public List<Location> GetAllLocation()
        {
            List<LocationDTO> locationDtos = dapper.GetAllLocation();
            List<Location> locations = MapLocationDTOToModelList(locationDtos);
            
            return locations;
        }

        /// <summary>
        /// Добавляем новую запись Location в БД
        /// </summary>
        /// <param name="model"></param>
        public void AddNewLocation(Location model)
        {
            locationDTO = MapModelToLocationDTO(model);
            dapper.AddNewLocation(locationDTO);
        }

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="location"></param>
        private LocationDTO MapModelToLocationDTO(Location location)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Location, LocationDTO>()
            .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex))
            .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
            .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
            .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
            .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
            .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber)));

            Mapper mapper = new Mapper(config);

            locationDTO = mapper.Map<LocationDTO>(location);
            return locationDTO;
        }

        private Location MapLocationDTOToModel(LocationDTO locationDTO)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<LocationDTO, Location>()
                .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
                .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
                .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
                .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber)));

            Mapper mapper = new Mapper(config);

            location = mapper.Map<Location>(locationDTO);
            return location;
        }

        private List<Location> MapLocationDTOToModelList(List<LocationDTO> locationDtos)
        {
            List<Location> tmp = new List<Location>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<LocationDTO, Location>()
                .ForMember(dest => dest.LocationIndex, option => option.MapFrom(source => source.LocationIndex))
                .ForMember(dest => dest.Country, option => option.MapFrom(source => source.Country))
                .ForMember(dest => dest.City, option => option.MapFrom(source => source.City))
                .ForMember(dest => dest.Street, option => option.MapFrom(source => source.Street))
                .ForMember(dest => dest.HouseNumber, option => option.MapFrom(source => source.HouseNumber))
                .ForMember(dest => dest.ApartmentNumber, option => option.MapFrom(source => source.ApartmentNumber)));

            Mapper mapper = new Mapper(config);

            tmp = mapper.Map<List<Location>>(locationDtos);
            return tmp;
        }
    }
}
