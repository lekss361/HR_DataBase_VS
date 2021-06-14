using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Dapper;
using HR_DataBase_VSDAL.DTO;
using System.Collections.Generic;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class PositionsWithDirectionNameLogic
    {
        PositionsWithDirectionName positionsWithDirectionNameDTO = new PositionsWithDirectionName();
        DapperPositionsWithDirectionName dapper = new DapperPositionsWithDirectionName();
        MappersController mappersController = new MappersController();

        public List<PositionsWithDirectionName> GetAllPositionsWithDirectionName()
        {
            List<PositionsWithDirectionNameDTO> positionsWithDirectionNameDTODtos = dapper.GetPositionsWithDirectionName();
            List<PositionsWithDirectionName> positionsWithDirectionName = mappersController.MapPositionsWithDirectionNameDTOToModelList(positionsWithDirectionNameDTODtos);
            positionsWithDirectionNameDTODtos.Clear();

            return positionsWithDirectionName;
        }
    }
}
