using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public interface IEntitiy
    {
        int ID { get; set; }
        public DateTime InDate { get; set; }
    }
}
