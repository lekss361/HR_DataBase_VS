using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class MapperPreviousJob
    {
        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="previousJob"></param>
        public PreviousJobDTO MapToPreviousJobDTO(PreviousJob previousJob)
        {
            PreviousJobDTO previousJobDTO = new PreviousJobDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PreviousJob, PreviousJobDTO>()
                .ForMember(dest => dest.StartDate, option => option.MapFrom(source => source.StartDate))
                .ForMember(dest => dest.DismassDate, option => option.MapFrom(source => source.DismassDate))
                .ForMember(dest => dest.Description, option => option.MapFrom(source => source.Description)));

            Mapper mapper = new Mapper(config);
            PreviousJobDapper dapper = new PreviousJobDapper();

            previousJobDTO = mapper.Map<PreviousJobDTO>(previousJob);
            dapper.AddNewPreviousJob(previousJobDTO);
            return previousJobDTO;
   
        }

    }
}
