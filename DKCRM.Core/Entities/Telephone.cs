using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Telephone
    {
        public int TelephoneID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string? PrefixCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Type { get; set; }
       //public virtual Customer? CustomerID { get; set; }
    }
}
