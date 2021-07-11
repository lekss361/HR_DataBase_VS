namespace HR_DataBase_VSDAL.Models
{
   public class DivisionByCompanyDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string DirectionName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DivisionByCompanyDTO dTO &&
                   id == dTO.id &&
                   Name == dTO.Name &&
                   DirectionName == dTO.DirectionName &&
                   Phone == dTO.Phone &&
                   Email == dTO.Email &&
                   Country == dTO.Country &&
                   City == dTO.City;
        }
    }
}