using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Defination_ATT : Defination
    {
        public int AttributeID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string? AttributeName { get; set; }
        public virtual List<Defination?> DefinationID { get; set; }
        public bool DisplayFlag { get; set; }
    }
}
