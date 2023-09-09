using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Statu
    {
        public int StatuID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string? StatuName { get; set; }
        public int? StatuCode { get; set;}
    }
}
