using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;
using System.Collections;


namespace HR_DataBase_VSBLL.Mappers
{
   public class DivisionByCompanyLogic
    {
        DapperDivisionByCompany dapper = new DapperDivisionByCompany();
        MappersController mappersController = new MappersController();

        public List<DivisionByCompany> GetDivisionByCompanyID(int id)
        {
            List<DivisionByCompanyDTO> divisionByCompanyDTODtos = dapper.GetDivisionByCompanyID(id);
            List<DivisionByCompany> divisionByCompany = mappersController.MapDivisionByCompanyDTOToModelList(divisionByCompanyDTODtos);
            return divisionByCompany;
        }
    }
}
