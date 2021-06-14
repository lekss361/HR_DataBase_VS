using System.Collections.Generic;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class SkillNameLogic
    {
        private int _id;
        SkillNameDapper dapper = new SkillNameDapper();
        SkillNameWithTypeDTO skillNameWithTypeDto = new SkillNameWithTypeDTO();
        List<SkillNameWithType> skillNameWithTypes = new List<SkillNameWithType>();
        private List<SkillNameWithTypeDTO> skillNameWithTypeDTO = new List<SkillNameWithTypeDTO>();
        MappersController mappersController = new MappersController();

        public SkillNameWithTypeDTO AddNewSkillName(SkillNameWithType skillName)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SkillNameWithType, SkillNameWithTypeDTO>());
            Mapper mapper = new Mapper(config);
            skillNameWithTypeDto = mappersController.MapToSkillNameDTO(skillName);
            dapper.AddNewSkillName(skillNameWithTypeDto);
            return skillNameWithTypeDto;
        }

        public List<SkillNameWithType> GetSkillNameByTypeId(int id)
        {
            _id = id;
            skillNameWithTypeDTO = dapper.GetSkillNameByTypeId(_id);
            skillNameWithTypes = mappersController.MapSkillNameByIdDTOToModelList(skillNameWithTypeDTO);
            return skillNameWithTypes;
        }

        public List<SkillNameWithType> GetSkillNameByAllType()
        {
            skillNameWithTypeDTO = dapper.GetSkillNameByAllType();
            skillNameWithTypes = mappersController.MapSkillNameByIdDTOToModelList(skillNameWithTypeDTO);
            return skillNameWithTypes;
        }

    }
}
