using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class Location
    {
        public int id { get; set; }
        public int? LocationIndex { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }

        public Location()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   id == location.id &&
                   LocationIndex == location.LocationIndex &&
                   Country == location.Country &&
                   City == location.City &&
                   Street == location.Street &&
                   HouseNumber == location.HouseNumber &&
                   ApartmentNumber == location.ApartmentNumber;
        }
    }
}