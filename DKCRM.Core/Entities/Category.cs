﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class Category : IEntitiy
    {
        public int CategoryID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }

    }
}
