namespace HR_DataBase_VSDAL.Models
{
    public class ContactsDTO
    {
        public int id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Information { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ContactsDTO dTO &&
                   id == dTO.id &&
                   Phone == dTO.Phone &&
                   Email == dTO.Email &&
                   Information == dTO.Information;
        }
    }
}