﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using System.Collections;

namespace HR_DataBase_VSBLL.Mappers
{ 
   public class MapperProjectsWithDirectionName
    {
        ProjectsWithDirectionName projectsWithDirectionNameDTO = new ProjectsWithDirectionName();
        ProjectsWithDirectionName rojectsWithDirectionName = new ProjectsWithDirectionName();
        DapperProjectsWithDirectionName dapper = new DapperProjectsWithDirectionName();

        public List<ProjectsWithDirectionName> GetAllProjectsWithDirectionName()
        {
            List<ProjectsWithDirectionNameDTO> projectsWithDirectionNameDTODtos = dapper.GetProjectsWithDirectionName();
            List<ProjectsWithDirectionName> projectsWithDirectionName = MapProjectsWithDirectionNameDTOToModelList(projectsWithDirectionNameDTODtos);
            projectsWithDirectionNameDTODtos.Clear();

            return projectsWithDirectionName;
        }

        private List<ProjectsWithDirectionName> MapProjectsWithDirectionNameDTOToModelList(List<ProjectsWithDirectionNameDTO> projectsWithDirectionNameDTODtos)
        {
            List<ProjectsWithDirectionName> sda = new List<ProjectsWithDirectionName>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProjectsWithDirectionNameDTO, ProjectsWithDirectionName>()
                .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name))
                .ForMember(dest => dest.DirectionName, option => option.MapFrom(source => source.DirectionName))
                .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information)));

            Mapper mapper = new Mapper(config);

            sda = mapper.Map<List<ProjectsWithDirectionName>>(projectsWithDirectionNameDTODtos);
            return sda;
        }

    }
}
