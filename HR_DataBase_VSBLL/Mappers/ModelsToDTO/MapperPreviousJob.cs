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
        public PreviousWorkDTO MapToPreviousJobDTO(PreviousWork previousJob)
        {
            PreviousWorkDTO previousJobDTO = new PreviousWorkDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PreviousWork, PreviousWorkDTO>()
                .ForMember(dest => dest.WorkerID, option => option.MapFrom(source => source.WorkerID))
                .ForMember(dest => dest.StartDate, option => option.MapFrom(source => source.StartDate))
                .ForMember(dest => dest.EndDate, option => option.MapFrom(source => source.EndDate))
                .ForMember(dest => dest.Information, option => option.MapFrom(source => source.Information))

                
                );

            Mapper mapper = new Mapper(config);
            PreviousWorkDapper dapper = new PreviousWorkDapper();

            previousJobDTO = mapper.Map<PreviousWorkDTO>(previousJob);
            dapper.AddPreviousWork(previousJobDTO);
            return previousJobDTO;
   
        }

    }
}
