﻿using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models
{
    public class Characteristic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
