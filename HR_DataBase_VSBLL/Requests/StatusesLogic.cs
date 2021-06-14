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
    public class StatusesLogic
    {
        private StatusesDapper dapper;
        private StatusesDTO statusesDTO;
        MappersController mappersController = new MappersController();

        public StatusesDTO AddNewStatuses(Statuses statuses)
        {
            statusesDTO = mappersController.MapToStatusesDTO(statuses);
            dapper.AddNewStatuses(statusesDTO);
            return statusesDTO;
        }
    }
}
