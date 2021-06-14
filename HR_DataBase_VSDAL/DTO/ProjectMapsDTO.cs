using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.DTO
{
    public class ProjectMapsDTO
    {
        public int WorkerID { get; set; }
        public int ProjectID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ProjectMapsDTO dTO &&
                   WorkerID == dTO.WorkerID &&
                   ProjectID == dTO.ProjectID;
        }
    }
}