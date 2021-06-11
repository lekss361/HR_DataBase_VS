using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DataBase_VSBLL.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Information { get; set; }

        public Contacts()
        {
        }
    }
}
