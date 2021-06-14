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
    public class PreviousJobLogic
    {
        MappersController mappersController = new MappersController();
        PreviousWorkDapper dapper = new PreviousWorkDapper();
        PreviousWorkDTO previousJobDTO = new PreviousWorkDTO();

        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="previousJob"></param>
        public int AddPreviousWork(PreviousWork previousJob)
        {
            previousJobDTO = mappersController.MapToPreviousWorkDTO(previousJob);
            return dapper.AddPreviousWork(previousJobDTO);
        }
    }
}
