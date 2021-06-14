using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class MapperStatuses
    {


        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="statuses"></param>
        public StatusesDTO MapToStatusesDTO(Statuses statuses)
        {
            StatusesDTO statusesDTO = new StatusesDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Statuses, StatusesDTO>()

            .ForMember(dest => dest.Name, option => option.MapFrom(source => source.Name)));


            Mapper mapper = new Mapper(config);
            StatusesDapper dapper = new StatusesDapper();

            statusesDTO = mapper.Map<StatusesDTO>(statuses);
            dapper.AddNewStatuses(statusesDTO);
            return statusesDTO;
        }


    }
}
