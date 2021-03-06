using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.Models
{
    public class CompaniesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public int ContactID { get; set; }
        public int LocationID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is CompaniesDTO company &&
                   Id == company.Id &&
                   Name == company.Name &&
                   Information == company.Information &&
                   ContactID == company.ContactID &&
                   LocationID == company.LocationID;
        }
    }
}
