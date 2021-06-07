﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.Models;

namespace HR_DataBase_VSBLL.Mappers
{
    class MapperWorker
    {
        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="worker"></param>
        public WorkersDTO MapToLocationDTO(Worker worker)
        {
            WorkersDTO workersDTO = new WorkersDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Worker, WorkersDTO>()
                .ForMember(dest => dest.BirthDay, option => option.MapFrom(source => source.BirthDay))
                .ForMember(dest => dest.ContactID, option => option.MapFrom(source => source.ContactID))
                .ForMember(dest => dest.Education, option => option.MapFrom(source => source.Education))
                .ForMember(dest => dest.FirstName, option => option.MapFrom(source => source.FirstName))
                .ForMember(dest => dest.LastName, option => option.MapFrom(source => source.LastName))
                .ForMember(dest => dest.LocationID, option => option.MapFrom(source => source.LocationID))
                .ForMember(dest => dest.Sex, option => option.MapFrom(source => source.Sex))
                .ForMember(dest => dest.Hobby, option => option.MapFrom(source => source.Hobby)));

            Mapper mapper = new Mapper(config);
            DapperWorker dapper = new DapperWorker();

            workersDTO = mapper.Map<WorkersDTO>(worker);
            dapper.AddNewWorker(workersDTO);
            return workersDTO;
        }
    }
}
