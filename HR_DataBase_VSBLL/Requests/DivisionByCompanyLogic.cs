using System.Collections.Generic;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;


namespace HR_DataBase_VSBLL.Mappers
{
    public class DivisionByCompanyLogic
    {
        private DapperDivisionByCompany dapper = new DapperDivisionByCompany();
        private MappersController mappersController = new MappersController();

        public List<DivisionByCompany> GetDivisionByCompanyID(int id)
        {
            List<DivisionByCompanyDTO> divisionByCompanyDTODtos = dapper.GetDivisionByCompanyID(id);
            return mappersController.MapDivisionByCompanyDTOToModel(divisionByCompanyDTODtos);
        }
    }
}
