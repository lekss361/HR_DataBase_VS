using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers
{
    public class DivisionsLogic
    {
        private DapperDivision dapper = new DapperDivision();
        private MappersController mappersController = new MappersController();
        private DivisionsDTO divisionsDTO = new DivisionsDTO();
        private DivisionWithForeignKeyValueDTO divisionWithKeyDTO = new DivisionWithForeignKeyValueDTO();

        public int AddNewDivision(Divisions model)
        {
            divisionsDTO = mappersController.MapDivisionsModelToDTO(model);
            return dapper.AddNewDivision(divisionsDTO);
        }

        public int UpdateDivisionByid(Divisions model, int id)
        {
            divisionsDTO = mappersController.MapDivisionsModelToDTO(model);
            return dapper.UpdateDivisoonsById(divisionsDTO, id);
        }

        public DivisionWithForeignKeyValue GetDivisionByID(int id)
        {
            divisionWithKeyDTO = dapper.GetDivisionByID(id);
            return mappersController
                .MapDivisionWithForeignKeyValueDTOToModel(divisionWithKeyDTO);
        }
    }
}