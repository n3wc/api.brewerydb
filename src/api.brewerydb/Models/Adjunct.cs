﻿using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models
{
    public class Adjunct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string CategoryDisplay { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
