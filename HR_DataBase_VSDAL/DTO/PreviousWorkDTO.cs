using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.DTO
{
    public class PreviousWorkDTO
    {
        public int WorkerID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Information { get; set; }
    }
}
