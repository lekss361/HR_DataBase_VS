using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.Models
{
    public class WorkersDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthDay { get; set; }
        public string Education { get; set; }
        public int? ContactID { get; set; }
        public int? LocationID { get; set; }
        public string Sex { get; set; }
        public string Hobby { get; set; }

        public WorkersDTO
        (
            string firstName,
            string lastName,
            int birthDay,
            string education,
            int? contactID,
            int? locationID,
            string sex,
            string hobby = null
        )
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Education = education;
            ContactID = contactID;
            LocationID = locationID;
            Sex = sex;
            Hobby = hobby;
        }
    }
}
