using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Ticket : IEntitiy
    {
        public int TicketID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        //public virtual Request? RequestID { get; set; }
        public virtual User? PersonelID { get; set; }
        //public virtual Statu? StatuID { get; set; }
        //public virtual Customer? CustomerID { get; set;}
    }
}
