using System.Collections.Generic;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class LocationLogic
    {
        private LocationDTO locationDTO = new LocationDTO();
        private DapperLocation dapper = new DapperLocation();
        private MappersController mappersController = new MappersController();

        public Location GetLocationByID(int ID)
        {
            locationDTO = dapper.GetLocationByID(ID);
            return mappersController.MapLocationDTOToModel(locationDTO);
        }

        public List<Location> GetAllLocation()
        {
            List<LocationDTO> locationDtos = dapper.GetAllLocation();
            return mappersController.MapLocationDTOToModel(locationDtos);
        }

        public int AddNewLocation(Location model)
        {
            locationDTO = mappersController.MapLocationModelToDTO(model);
            return dapper.AddNewLocation(locationDTO);
        }

        public int UpdateLocationByid(Location model, int id)
        {
            locationDTO = mappersController.MapLocationModelToDTO(model);
            return dapper.UpdateLocationById(locationDTO, id);
        }
    }
}