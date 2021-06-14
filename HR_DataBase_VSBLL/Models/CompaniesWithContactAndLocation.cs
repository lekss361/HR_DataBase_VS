using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class CompaniesWithContactAndLocation
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }

        public override bool Equals(object obj)
        {
            return obj is CompaniesWithContactAndLocation location &&
                   id == location.id &&
                   Name == location.Name &&
                   Information == location.Information &&
                   Phone == location.Phone &&
                   Email == location.Email &&
                   City == location.City &&
                   Street == location.Street &&
                   HouseNumber == location.HouseNumber;
        }
    }
}
