using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Address :IEntitiy
    {
        public int ID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        //public virtual Customer? CustomerID { get; set; }
        public virtual City CityCode { get; set; }
        public virtual District? DistrictCode { get; set; }

    }
}
