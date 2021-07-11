namespace HR_DataBase_VSBLL.Models
{
    public class Divisions
    {
        
        public string Name { get; set; }
        public string Information { get; set; }
        public int CompanyID { get; set; }
        public int ContactID { get; set; }
        public int LocationID { get; set; }
        public int DirectionsID { get; set; }

        public Divisions()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Divisions divisions &&
                   Name == divisions.Name &&
                   Information == divisions.Information &&
                   CompanyID == divisions.CompanyID &&
                   ContactID == divisions.ContactID &&
                   LocationID == divisions.LocationID &&
                   DirectionsID == divisions.DirectionsID;
        }
    }
}