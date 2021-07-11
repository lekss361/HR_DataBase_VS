namespace HR_DataBase_VSDAL.Models
{
    public class CompanyWithForeignKeyValueDTO
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

        public override bool Equals(object obj)
        {
            return obj is CompanyWithForeignKeyValueDTO dTO &&
                   id == dTO.id &&
                   ContactID == dTO.ContactID &&
                   LocationID == dTO.LocationID &&
                   Name == dTO.Name &&
                   Information == dTO.Information &&
                   Phone == dTO.Phone &&
                   Email == dTO.Email &&
                   ContactInformation == dTO.ContactInformation &&
                   Country == dTO.Country &&
                   City == dTO.City &&
                   Street == dTO.Street &&
                   HouseNumber == dTO.HouseNumber &&
                   ApartmentNumber == dTO.ApartmentNumber &&
                   LocationIndex == dTO.LocationIndex;
        }
    }
}