using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSBLL.Mappers
{
    public class MapperProjectMaps
    {
        ProjectMapsDTO projectMapsDTO = new ProjectMapsDTO();
        DapperProjectMaps dapperProjectMaps = new DapperProjectMaps();

        public void AddNewProjectMaps(ProjectMaps projectMaps)
        {
            projectMapsDTO = MapToDirectionsDTO(projectMaps);
            dapperProjectMaps.AddNewProjectMaps(projectMapsDTO);
        }
        public ProjectMapsDTO MapToDirectionsDTO(ProjectMaps projectMaps)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProjectMaps, ProjectMapsDTO>());
            Mapper mapper = new Mapper(config);
            projectMapsDTO = mapper.Map<ProjectMapsDTO>(projectMaps);
            dapperProjectMaps.AddNewProjectMaps(projectMapsDTO);
            return projectMapsDTO;
        }
    }
}