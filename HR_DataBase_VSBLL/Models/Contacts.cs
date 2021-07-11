namespace HR_DataBase_VSBLL.Models
{
    public class Contacts
    {
        public int id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Information { get; set; }

        public Contacts()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Contacts contacts &&
                   id == contacts.id &&
                   Phone == contacts.Phone &&
                   Email == contacts.Email &&
                   Information == contacts.Information;
        }
    }
}