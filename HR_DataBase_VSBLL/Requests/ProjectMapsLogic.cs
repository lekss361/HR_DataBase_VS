using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;

namespace HR_DataBase_VSBLL.Mappers
{
    public class ProjectMapsLogic
    {
        private ProjectMapsDTO projectMapsDTO = new ProjectMapsDTO();
        private DapperProjectMaps dapperProjectMaps = new DapperProjectMaps();
        private MappersController mappersController = new MappersController();

        public void AddNewProjectMaps(ProjectMaps projectMaps)
        {
            projectMapsDTO = mappersController.MapProjectMapsModelsToDTO(projectMaps);
            dapperProjectMaps.AddNewProjectMaps(projectMapsDTO);
        }
    }
}