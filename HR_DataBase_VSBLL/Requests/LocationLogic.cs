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
    public class LocationLogic
    {
        int id;
        LocationDTO locationDTO = new LocationDTO();
        DapperLocation dapper = new DapperLocation();
        MappersController mappersController = new MappersController();

        /// <summary>
        /// поиск Location по ID
        /// </summary>
        /// <param name="ID">LocationID</param>
        /// <returns>LocationDTO</returns>
        public Location GetLocationByID(int ID)
        {
            locationDTO = dapper.GetLocationByID(ID);
            return mappersController.MapLocationDTOToModel(locationDTO);
        }

        public List<Location> GetAllLocation()
        {
            List<LocationDTO> locationDtos = dapper.GetAllLocation();
            List<Location> locations = mappersController.MapLocationDTOToModelList(locationDtos);

            return locations;
        }

        /// <summary>
        /// Добавляем новую запись Location в БД
        /// </summary>
        /// <param name="model"></param>
        public int AddNewLocation(Location model)
        {
            locationDTO = mappersController.MapModelToLocationDTO(model);
            id = dapper.AddNewLocation(locationDTO);
            return id;
        }

        /// <summary>
        /// Изменяем запись Location в БД по Id
        /// </summary>
        /// <param name="model"></param>
        public int UpdateLocationByid(Location model,int id)
        {
            locationDTO = mappersController.MapModelToLocationDTO(model);
            id = dapper.UpdateLocationById(locationDTO,id);
            return id;
        }
    }
}