﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class City : IEntitiy
    {
        public int CityID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        
    }
}
