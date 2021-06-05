using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class PreviousWork
    {
        public DateTime StartDate { get; set; }
        public DateTime DismassDate { get; set; }
        public string Description { get; set; }


        public PreviousWork()
        {
        }
    }
}
