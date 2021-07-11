namespace HR_DataBase_VSBLL.Models
{
    public class DivisionByCompany
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string DirectionName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public DivisionByCompany()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is DivisionByCompany company &&
                   id == company.id &&
                   Name == company.Name &&
                   DirectionName == company.DirectionName &&
                   Phone == company.Phone &&
                   Email == company.Email &&
                   Country == company.Country &&
                   City == company.City;
        }
    }
}