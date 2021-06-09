using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class Divisions
    {
        
        public string Name { get; set; }
        public string Information { get; set; }
        public int CompanyID { get; set; }
        public int ContactID { get; set; }
        public int LocationID { get; set; }
        public int DirectionsID { get; set; }

        public Divisions()
        {
        }
    }
}
