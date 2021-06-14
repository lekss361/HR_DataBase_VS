using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.Models;
using System.Collections.Generic;

namespace HR_DataBase_VSBLL.Mappers
{
    public class ProjectsWithDirectionNameLogic
    {
        DapperProjectsWithDirectionName dapper = new DapperProjectsWithDirectionName();
        MappersController mappersController = new MappersController();

        public List<ProjectsWithDirectionName> GetAllProjectsWithDirectionName()
        {
            List<ProjectsWithDirectionNameDTO> projectsWithDirectionNameDTODtos = dapper.GetProjectsWithDirectionName();
            List<ProjectsWithDirectionName> projectsWithDirectionName = mappersController.MapProjectsWithDirectionNameDTOToModelList(projectsWithDirectionNameDTODtos);
            return projectsWithDirectionName;
        }
    }
}
