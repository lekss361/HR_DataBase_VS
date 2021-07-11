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

        public override bool Equals(object obj)
        {
            return obj is DivisionWithForeignKeyValueDTO dTO &&
                   CompanyID == dTO.CompanyID &&
                   DirectionId == dTO.DirectionId &&
                   ContactID == dTO.ContactID &&
                   LocationID == dTO.LocationID &&
                   Name == dTO.Name &&
                   Information == dTO.Information &&
                   CompanyName == dTO.CompanyName &&
                   DirectionName == dTO.DirectionName &&
                   Phone == dTO.Phone &&
                   Email == dTO.Email &&
                   ContactInformation == dTO.ContactInformation &&
                   Country == dTO.Country &&
                   City == dTO.City &&
                   Street == dTO.Street &&
                   ApartmentNumber == dTO.ApartmentNumber &&
                   HouseNumber == dTO.HouseNumber &&
                   LocationIndex == dTO.LocationIndex;
        }
    }
}