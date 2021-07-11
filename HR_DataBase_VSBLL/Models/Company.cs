namespace HR_DataBase_VSBLL.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public int ContactID { get; set; }
        public int LocationID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Company company &&
                   Id == company.Id &&
                   Name == company.Name &&
                   Information == company.Information &&
                   ContactID == company.ContactID &&
                   LocationID == company.LocationID;
        }
    }
}