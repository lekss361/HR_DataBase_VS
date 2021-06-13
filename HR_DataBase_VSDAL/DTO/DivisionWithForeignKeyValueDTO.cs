using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.Models
{
   public class DivisionWithForeignKeyValueDTO
    {
        public int CompanyID { get; set; }
        public int DirectionId { get; set; }
        public int ContactID { get; set; }
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string CompanyName { get; set; }
        public string DirectionName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ContactInformation { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int ApartmentNumber { get; set; }
        public int HouseNumber { get; set; }
        public int LocationIndex { get; set; }
        


    }
}
