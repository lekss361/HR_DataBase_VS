using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.Models
{
    public class WorkersDTO
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? BirthDay { get; set; }
        public string? Education { get; set; }
        public int? ContactID { get; set; }
        public int? LocationID { get; set; }
        public string? Sex { get; set; }
        public int? StatusID { get; set; }
        public int? PositionID { get; set; }
        public int? DivisionID { get; set; }
        public string? Hobby { get; set; }

        public override bool Equals(object obj)
        {
            return obj is WorkersDTO dTO &&
                   Id == dTO.Id &&
                   FirstName == dTO.FirstName &&
                   LastName == dTO.LastName &&
                   Patronymic == dTO.Patronymic &&
                   BirthDay == dTO.BirthDay &&
                   Education == dTO.Education &&
                   ContactID == dTO.ContactID &&
                   LocationID == dTO.LocationID &&
                   Sex == dTO.Sex &&
                   StatusID == dTO.StatusID &&
                   PositionID == dTO.PositionID &&
                   DivisionID == dTO.DivisionID &&
                   Hobby == dTO.Hobby;
        }

        //public WorkersDTO
        //(
        //    int id,
        //    string firstName,
        //    string lastName,
        //    string patronymic,
        //    string birthDay,
        //    string education,
        //    int? contactID,
        //    int? locationID,
        //    string sex,
        //    int statusID,
        //    int? positionID,
        //    int? divisionID,
        //    string hobby = null
        //)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Patronymic = patronymic;
        //    BirthDay = birthDay;
        //    Education = education;
        //    ContactID = contactID;
        //    LocationID = locationID;
        //    Sex = sex;
        //    StatusID = statusID;
        //    PositionID = positionID;
        //    DivisionID = divisionID;
        //    Hobby = hobby;
        //}

        //public WorkersDTO()
        //{

        //}
    }
}
