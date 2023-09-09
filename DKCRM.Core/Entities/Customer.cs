using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Customer : IEntitiy
    {
        public int CustomerID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string? Name { get; set; }
        public string? SurName { get; set; }
    }
}
