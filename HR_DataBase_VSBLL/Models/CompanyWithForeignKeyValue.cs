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

        public override bool Equals(object obj)
        {
            return obj is CompanyWithForeignKeyValue value &&
                   id == value.id &&
                   ContactID == value.ContactID &&
                   LocationID == value.LocationID &&
                   Name == value.Name &&
                   Information == value.Information &&
                   Phone == value.Phone &&
                   Email == value.Email &&
                   ContactInformation == value.ContactInformation &&
                   Country == value.Country &&
                   City == value.City &&
                   Street == value.Street &&
                   HouseNumber == value.HouseNumber &&
                   ApartmentNumber == value.ApartmentNumber &&
                   LocationIndex == value.LocationIndex;
        }
    }
}