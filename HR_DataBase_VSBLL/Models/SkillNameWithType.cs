using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class SkillNameWithType
    {
        public int Id { get; set; }
        public int SkillTypeID { get; set; }
        public string SkillName { get; set; }
        public string SkillType { get; set; }
    }
}