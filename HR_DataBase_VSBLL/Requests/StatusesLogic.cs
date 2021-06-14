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
        private StatusesDTO statusesDTO = new StatusesDTO();
        private MappersController mappersController = new MappersController();
        private StatusesDapper dapper = new StatusesDapper();
        private Statuses statuses = new Statuses();

        public int AddNewStatuses(Statuses statuses)
        {
            statusesDTO = mappersController.MapStatusesModelsToDTO(statuses);
            return dapper.AddNewStatuses(statusesDTO);
        }
        public List<Statuses> GetAllStatuses()
        {
            List<StatusesDTO> statusesDTO = dapper.GetAllStatuses();
            List<Statuses> statuses = mappersController.MapStatusesDTOToModels(statusesDTO);
            return statuses;
        }
    }
}