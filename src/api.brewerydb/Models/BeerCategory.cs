using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models
{
    public class BeerCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
