﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKCRM.Core.Entities
{
    public class User : IEntitiy
    {
        public int ID { get; set; }
        public DateTime InDate { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsBO { get; set; }
        public bool? IsAgent { get; set; }
        public bool? IsAdmin { get; set; }


    }
}