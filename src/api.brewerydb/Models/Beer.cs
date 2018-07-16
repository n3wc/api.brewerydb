using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models
{
    public class Beer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NameDisplay { get; set; }
        public string Description { get; set; }
        public string Abv { get; set; }
        public int AvailableId { get; set; }
        public int StyleId { get; set; }
        public string IsOrganic { get; set; }
        public string Status { get; set; }
        public string StatusDisplay { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Available Available { get; set; }
        public Style Style { get; set; }
        public int? GlasswareId { get; set; }
        public int? SrmId { get; set; }
        public Glass Glass { get; set; }
        public Srm Srm { get; set; }
        public string Ibu { get; set; }
        public Images Labels { get; set; }
        public string OriginalGravity { get; set; }
        public string ServingTemperature { get; set; }
        public string ServingTemperatureDisplay { get; set; }
        public List<Brewery> Breweries { get; set; }
    }
}
