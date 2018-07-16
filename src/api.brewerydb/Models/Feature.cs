using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models
{
    public class Feature
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Week { get; set; }
        public string BreweryId { get; set; }
        public Brewery Brewery { get; set; }
        public string BeerId { get; set; }
        public Beer Beer { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
