using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class Worker
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
            return obj is Worker worker &&
                   Id == worker.Id &&
                   FirstName == worker.FirstName &&
                   LastName == worker.LastName &&
                   Patronymic == worker.Patronymic &&
                   BirthDay == worker.BirthDay &&
                   Education == worker.Education &&
                   ContactID == worker.ContactID &&
                   LocationID == worker.LocationID &&
                   Sex == worker.Sex &&
                   StatusID == worker.StatusID &&
                   PositionID == worker.PositionID &&
                   DivisionID == worker.DivisionID &&
                   Hobby == worker.Hobby;
        }
    }
}