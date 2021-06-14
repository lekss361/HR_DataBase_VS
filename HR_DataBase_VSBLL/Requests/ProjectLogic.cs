using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSBLL.Models;

namespace HR_DataBase_VSBLL.Mappers
{
    public class ProjectLogic
    {
        private ProjectDTO projectDTO = new ProjectDTO();
        private DapperProjects dapper = new DapperProjects();
        private MappersController mappersController = new MappersController();

        public ProjectDTO GetByID(int ID)
        {
            projectDTO = dapper.GetProjectByID(ID);
            return projectDTO;
        }

        public void AddNew(Project model)
        {
            projectDTO = mappersController.MapProjectModelToDTO(model);
            dapper.AddNewProject(projectDTO);
        }
    }
}