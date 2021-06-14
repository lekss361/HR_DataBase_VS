using System.Collections.Generic;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class SkillNameLogic
    {
        private SkillNameDapper dapper = new SkillNameDapper();
        private SkillNameWithTypeDTO skillNameWithTypeDto = new SkillNameWithTypeDTO();
        private List<SkillNameWithTypeDTO> skillNameWithTypeDTO = new List<SkillNameWithTypeDTO>();
        private MappersController mappersController = new MappersController();

        public int AddNewSkillName(SkillNameWithType skillName)
        {
            skillNameWithTypeDto = mappersController.MapSkillNameWithTypeModelToDTO(skillName);
            return dapper.AddNewSkillName(skillNameWithTypeDto);
        }

        public List<SkillNameWithType> GetSkillNameByTypeId(int id)
        {
            skillNameWithTypeDTO = dapper.GetSkillNameByTypeId(id);
            return mappersController.MapSkillNameWithTypeDTOToModel(skillNameWithTypeDTO);
        }

        public List<SkillNameWithType> GetSkillNameByAllType()
        {
            skillNameWithTypeDTO = dapper.GetSkillNameByAllType();
            return mappersController.MapSkillNameWithTypeDTOToModel(skillNameWithTypeDTO);
        }

    }
}
