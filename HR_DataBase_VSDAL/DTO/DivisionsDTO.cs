using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSDAL.Models
{
    public class DivisionsDTO
    {
       
        public string Name { get; set; }
        public string Information { get; set; }
        public int CompanyID { get; set; }
        public int ContactID { get; set; }
        public int LocationID { get; set; }
        public int DirectionsID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DivisionsDTO dTO &&
                   Name == dTO.Name &&
                   Information == dTO.Information &&
                   CompanyID == dTO.CompanyID &&
                   ContactID == dTO.ContactID &&
                   LocationID == dTO.LocationID &&
                   DirectionsID == dTO.DirectionsID;
        }
    }
}
