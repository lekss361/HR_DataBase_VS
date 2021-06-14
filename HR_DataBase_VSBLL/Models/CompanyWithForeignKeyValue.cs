using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
   public class CompanyWithForeignKeyValue
    {
        public int id { get; set; }
        public int ContactID { get; set; }
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ContactInformation { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string LocationIndex { get; set; }
    }
}
