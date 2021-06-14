using System.Collections.Generic;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class DirectionsLogic
    {
        private DirectionsDTO directionsDTO = new DirectionsDTO();
        private MappersController mappersController = new MappersController();
        private DirectionsDapper dapper = new DirectionsDapper();

        public int AddDirections(Directions directions)
        {
            directionsDTO = mappersController.MapDirectionsModelToDTO(directions);
            return dapper.AddNewDirections(directionsDTO);
        }

        public List<Directions> GetAllDirections()
        {
            List<DirectionsDTO> directionsDTO = dapper.GetAllDirections();
            return mappersController.MapDirectionsDTOToModel(directionsDTO);
        }
    }
}
