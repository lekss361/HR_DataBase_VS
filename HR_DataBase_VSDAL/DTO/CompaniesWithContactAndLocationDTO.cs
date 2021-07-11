namespace HR_DataBase_VSDAL.DTO
{
    public class CompaniesWithContactAndLocationDTO
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
            return obj is CompaniesWithContactAndLocationDTO dTO &&
                   id == dTO.id &&
                   Name == dTO.Name &&
                   Information == dTO.Information &&
                   Phone == dTO.Phone &&
                   Email == dTO.Email &&
                   City == dTO.City &&
                   Street == dTO.Street &&
                   HouseNumber == dTO.HouseNumber;
        }
    }
}