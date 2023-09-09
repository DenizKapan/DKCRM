using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Request : IEntitiy
    {
        public int RequestID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string? RequestName { get; set; }
        public bool DisplayFlag { get; set; }
        //public virtual Category? CategoryID { get; set; }
        
    }
}
