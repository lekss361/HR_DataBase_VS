using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSBLL.Models;
using AutoMapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class MapperProject
    {
        ProjectDTO projectDTO = new ProjectDTO();
        DapperProjects dapper = new DapperProjects();

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
            projectDTO = MapModelToDTO(model);
            dapper.AddNewProject(projectDTO);
        }

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="model"></param>
        private ProjectDTO MapModelToDTO(Project model)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Project, ProjectDTO>()
            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
            .ForMember(dest => dest.DirectionsID, option => option.MapFrom(source => source.DirectionsID))
            .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            projectDTO = mapper.Map<ProjectDTO>(model);
            return projectDTO;
        }

    }
}
