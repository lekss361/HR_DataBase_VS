using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class PreviousWork
    {
        public int WorkerID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Information { get; set; }


        public PreviousWork()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is PreviousWork work &&
                   WorkerID == work.WorkerID &&
                   StartDate == work.StartDate &&
                   EndDate == work.EndDate &&
                   Information == work.Information;
        }
    }
}
