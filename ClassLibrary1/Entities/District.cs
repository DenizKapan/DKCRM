using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class District : City
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int DistrictCode { get; set; }
        public City CityCode { get; set; }
    }
}
