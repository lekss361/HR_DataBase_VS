namespace HR_DataBase_VSDAL.Models
{
   public class WorkerWithForeignKeyValueDTO
    {
        public int? id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string BirthDay { get; set; }
        public string Sex { get; set; }
        public string Education { get; set; }
        public string Hobby { get; set; }
        public int? ContactID { get; set; }
        public int? LocationID { get; set; }
        public int? StatusID { get; set; }
        public int? PositionID { get; set; }
        public int? DivisionID { get; set; }
        public string CompanyName { get; set; }
        public string DivisionName { get; set; }
        public string StatusName { get; set; }
        public string PositionName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ContactInformation { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int ApartmentNumber { get; set; }
        public int HouseNumber { get; set; }
        public int LocationIndex { get; set; }
    }
}