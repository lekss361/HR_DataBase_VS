using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HR_DataBase_VSBLL.Models;
using HR_DataBase_VSDAL.Models;
using HR_DataBase_VSDAL.Dapper;

namespace HR_DataBase_VSBLL.Mappers.ModelsToDTO
{
    public class MapperSkillName
    {
        /// <summary>
        /// Mapper моделей UI в DTO
        /// </summary>
        /// <param name="skillName"></param>
        public SkillNameDTO MapToSkillNameDTO(SkillName skillName)
        {
            SkillNameDTO skillNameDTO = new SkillNameDTO();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<SkillName, SkillNameDTO>()
            .ForMember(dest => dest.Skill, option => option.MapFrom(source => source.Skill))
            .ForMember(dest => dest.SkillTypeID, option => option.MapFrom(source => source.SkillTypeID)));

            Mapper mapper = new Mapper(config);
            SkillNameDapper dapper = new SkillNameDapper();

            skillNameDTO = mapper.Map<SkillNameDTO>(skillName);
            dapper.AddNewSkillName(skillNameDTO);
            return skillNameDTO;
        }
    }
}
