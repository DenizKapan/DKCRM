using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Ticket 
    {
        public int TicketID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public Request RequestId { get; set; }
        public User PersonelID { get; set; }
        public SolutionGroup SolutionID { get; set; }
        public Statu StatuID { get; set; }
    }
}
