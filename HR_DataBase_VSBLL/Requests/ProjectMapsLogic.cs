using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;

namespace HR_DataBase_VSBLL.Mappers
{
    public class ProjectMapsLogic
    {
        ProjectMapsDTO projectMapsDTO = new ProjectMapsDTO();
        DapperProjectMaps dapperProjectMaps = new DapperProjectMaps();
        MappersController mappersController = new MappersController();

        public void AddNewProjectMaps(ProjectMaps projectMaps)
        {
            projectMapsDTO = mappersController.MapProjectMapsModelsToDTO(projectMaps);
            dapperProjectMaps.AddNewProjectMaps(projectMapsDTO);
        }
    }
}