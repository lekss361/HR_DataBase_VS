using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.Models
{
    public class LocationDTO
    {
        public int id { get; set; }
        public int? LocationIndex { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }

        public override bool Equals(object obj)
        {
            return obj is LocationDTO dTO &&
                   id == dTO.id &&
                   LocationIndex == dTO.LocationIndex &&
                   Country == dTO.Country &&
                   City == dTO.City &&
                   Street == dTO.Street &&
                   HouseNumber == dTO.HouseNumber &&
                   ApartmentNumber == dTO.ApartmentNumber;
        }
    }
}
