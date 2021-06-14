using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSBLL.Models;
using AutoMapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class ProjectLogic
    {
        ProjectDTO projectDTO = new ProjectDTO();
        DapperProjects dapper = new DapperProjects();
        MappersController mappersController = new MappersController();

        /// <summary>
        /// поиск данных по ID
        /// </summary>
        /// <param name="ID">ID записи</param>
        /// <returns>DTO записи из БД</returns>
        public ProjectDTO GetByID(int ID)
        {
            projectDTO = dapper.GetProjectByID(ID);
            return projectDTO;
        }

        /// <summary>
        /// Добавляем новую запись в БД
        /// </summary>
        /// <param name="model">Модель</param>
        public void AddNew(Project model)
        {
            projectDTO = mappersController.MapProjectModelToDTO(model);
            dapper.AddNewProject(projectDTO);
        }
    }
}
