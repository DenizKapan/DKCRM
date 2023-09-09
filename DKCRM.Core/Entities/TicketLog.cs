using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class TicketLog : IEntitiy
    {
        public int TicketLogID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public virtual Ticket? TicketID { get; set; }
        public string? TicketLogDescription { get; set; }
        public virtual User? UserID { get; set; }

    }
}
