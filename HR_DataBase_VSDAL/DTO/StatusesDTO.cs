using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.Models
{
    public class StatusesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is StatusesDTO dTO &&
                   Name == dTO.Name&&
                   Id == dTO.Id;
        }
    }
}