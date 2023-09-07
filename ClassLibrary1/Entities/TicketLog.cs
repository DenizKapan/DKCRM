using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class TicketLog : IEntitiy
    {
        public int ID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public Ticket? TicketID { get; set; }
        public string? TicketLogDescription { get; set; }
        public User? PersonelID { get; set; }

    }
}
