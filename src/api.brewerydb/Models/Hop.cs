using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models
{
    public class Hop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CountryOfOrigin { get; set; }
        public double AlphaAcidMin { get; set; }
        public double AlphaAcidMax { get; set; }
        public double BetaAcidMin { get; set; }
        public double BetaAcidMax { get; set; }
        public double HumuleneMin { get; set; }
        public double HumuleneMax { get; set; }
        public double CaryophylleneMin { get; set; }
        public double CaryophylleneMax { get; set; }
        public double CohumuloneMin { get; set; }
        public double CohumuloneMax { get; set; }
        public double MyrceneMin { get; set; }
        public double MyrceneMax { get; set; }
        public double FarneseneMin { get; set; }
        public double FarneseneMax { get; set; }
        public string IsNoble { get; set; }
        public string ForBittering { get; set; }
        public string ForFlavor { get; set; }
        public string ForAroma { get; set; }
        public string Category { get; set; }
        public string CategoryDisplay { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Country Country { get; set; }
    }
}
