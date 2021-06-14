using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class DivisionsLogic
    {
        MappersController mappersController = new MappersController();
        DivisionWithForeignKeyValueDTO divisionWithForeignKeyValueDTO = new DivisionWithForeignKeyValueDTO();
        DivisionWithForeignKeyValue divisionWithForeignKeyValue = new DivisionWithForeignKeyValue();
        DivisionsDTO divisionsDTO = new DivisionsDTO();
        DapperDivision dapper = new DapperDivision();

        public int UpdateDivisionByid(Divisions model, int id)
        {
            divisionsDTO = mappersController.MapDivisionsModelToDTO(model);
            id = dapper.UpdateDivisoonsById(divisionsDTO, id);
            return id;
        }

        public DivisionWithForeignKeyValue GetDivisionByID(int id)
        {
            divisionWithForeignKeyValueDTO = dapper.GetDivisionByID(id);
            divisionWithForeignKeyValue  = mappersController.MapDivisionWithForeignKeyValueDTOToModel(divisionWithForeignKeyValueDTO);
            return divisionWithForeignKeyValue;
        }
    }
}
