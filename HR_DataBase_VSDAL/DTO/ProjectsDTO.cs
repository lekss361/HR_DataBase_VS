using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.Models
{
    public class ProjectDTO
    {
        public string Name { get; set; }
        public int DirectionsID { get; set; }
        public string Information { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ProjectDTO dTO &&
                   Name == dTO.Name &&
                   DirectionsID == dTO.DirectionsID &&
                   Information == dTO.Information;
        }
    }
}
