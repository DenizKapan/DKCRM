using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class SolutionGroup
    {
        public int ID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string SolutionName { get; set; }
        public bool DisplayFlag { get; set; }
    }
}
