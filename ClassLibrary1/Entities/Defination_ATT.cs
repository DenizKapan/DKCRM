using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Defination_ATT : Defination
    {
        public int ID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public int AttributeID { get; set; }
        public string? AttributeName { get; set; }
        public Defination DefinationID { get; set; }
        public bool DisplayFlag { get; set; }
    }
}
