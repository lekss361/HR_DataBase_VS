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
    public class MapperSkillName
    {
        SkillNameDapper dapper = new SkillNameDapper();
        SkillNameWithTypeDTO skillNameWithTypeDto = new SkillNameWithTypeDTO();
        List<SkillNameWithType> skillNameWithTypes = new List<SkillNameWithType>();
        private List<SkillNameWithTypeDTO> skillNameWithTypeDTO = new List<SkillNameWithTypeDTO>();
        private int _id;
        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="skillName"></param>
        public SkillNameWithTypeDTO MapToSkillNameDTO(SkillNameWithType skillName)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SkillNameWithType, SkillNameWithTypeDTO>());
            Mapper mapper = new Mapper(config);
            skillNameWithTypeDto = mapper.Map<SkillNameWithTypeDTO>(skillName);
            dapper.AddNewSkillName(skillNameWithTypeDto);
            return skillNameWithTypeDto;
        }

        public List<SkillNameWithType> GetSkillNameByTypeId(int id)
        {
            _id = id;
            skillNameWithTypeDTO = dapper.GetSkillNameByTypeId(_id);
            skillNameWithTypes = MapSkillNameByIdDTOToModelList(skillNameWithTypeDTO);
            return skillNameWithTypes;
        }
        public List<SkillNameWithType> GetSkillNameByAllType()
        {
            skillNameWithTypeDTO = dapper.GetSkillNameByAllType();
            skillNameWithTypes = MapSkillNameByIdDTOToModelList(skillNameWithTypeDTO);
            return skillNameWithTypes;
        }

        private List<SkillNameWithType> MapSkillNameByIdDTOToModelList (List<SkillNameWithTypeDTO> skillNameByIdDtos)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SkillNameWithTypeDTO, SkillNameWithType>());
            Mapper mapper = new Mapper(config);
            skillNameWithTypes = mapper.Map<List<SkillNameWithType>>(skillNameByIdDtos);
            return skillNameWithTypes;
        }
    }
}
