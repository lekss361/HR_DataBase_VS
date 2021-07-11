namespace HR_DataBase_VSBLL.Models
{
   public class DivisionWithForeignKeyValue
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

        public override bool Equals(object obj)
        {
            return obj is DivisionWithForeignKeyValue value &&
                   CompanyID == value.CompanyID &&
                   DirectionId == value.DirectionId &&
                   ContactID == value.ContactID &&
                   LocationID == value.LocationID &&
                   Name == value.Name &&
                   Information == value.Information &&
                   CompanyName == value.CompanyName &&
                   DirectionName == value.DirectionName &&
                   Phone == value.Phone &&
                   Email == value.Email &&
                   ContactInformation == value.ContactInformation &&
                   Country == value.Country &&
                   City == value.City &&
                   Street == value.Street &&
                   ApartmentNumber == value.ApartmentNumber &&
                   HouseNumber == value.HouseNumber &&
                   LocationIndex == value.LocationIndex;
        }
    }
}