using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.Models
{
    public class SkillNameWithTypeDTO
    {
        public int Id { get; set; }
        public int SkillTypeID { get; set; }
        public string SkillName { get; set; }
        public string SkillType { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SkillNameWithTypeDTO dTO &&
                   Id == dTO.Id &&
                   SkillTypeID == dTO.SkillTypeID &&
                   SkillName == dTO.SkillName &&
                   SkillType == dTO.SkillType;
        }
    }
}