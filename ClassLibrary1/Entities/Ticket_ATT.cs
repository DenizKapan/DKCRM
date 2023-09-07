using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Ticket_ATT
    {
        public int ID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public Ticket? TicketID { get; set; }
        public string? ATTValue { get; set; }
        public User? PersonelID { get; set; }

    }
}
