using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;
using System.Collections.Generic;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class PositionsWithDirectionNameLogic
    {
        private DapperPositionsWithDirectionName dapper = new DapperPositionsWithDirectionName();
        private MappersController mappersController = new MappersController();

        public List<PositionsWithDirectionName> GetAllPositionsWithDirectionName()
        {
            List<PositionsWithDirectionNameDTO> positionsWithDirectionNameDTODtos = dapper.GetPositionsWithDirectionName();
            return mappersController.MapPositionsWithDirectionNameDTOToModel(positionsWithDirectionNameDTODtos);
        }
    }
}