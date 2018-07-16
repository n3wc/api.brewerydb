using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models
{
    public class Fermentable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string CategoryDisplay { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string CountryOfOrigin { get; set; }
        public int? SrmId { get; set; }
        public double? SrmPrecise { get; set; }
        public double? MoistureContent { get; set; }
        public double? CoarseFineDifference { get; set; }
        public int? DiastaticPower { get; set; }
        public double? DryYield { get; set; }
        public double? Potential { get; set; }
        public double? Protein { get; set; }
        public int? MaxInBatch { get; set; }
        public string RequiresMashing { get; set; }
        public DateTime UpdateDate { get; set; }
        public Srm Srm { get; set; }
        public Country Country { get; set; }
        public List<Characteristic> Characteristics { get; set; }
    }
}
