using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class CompaniesWithContactAndLocation
    {
        public string Name { get; set; }
        public string Information { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string LocationCity { get; set; }
        public string LocationStreet { get; set; }
        public string LocationHouse { get; set; }
    }
}
