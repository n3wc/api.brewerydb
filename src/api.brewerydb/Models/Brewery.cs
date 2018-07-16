using System;
using System.Collections.Generic;

namespace api.brewerydb.Models
{
    public class Brewery
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NameShortDisplay { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Established { get; set; }
        public string IsOrganic { get; set; }
        public Images Images { get; set; }
        public string Status { get; set; }
        public string StatusDisplay { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string IsMassOwned { get; set; }
        public string BrandClassification { get; set; }
        public string MailingListUrl { get; set; }
        public List<Location> Locations { get; set; }
        public List<SocialAccount> SocialAccounts { get; set; }
        public List<Guild> Guilds { get; set; }
        public List<AlternateName> AlternateNames { get; set; }

        public class AlternateName
        {
            public int Id { get; set; }
            public string AltName { get; set; }
            public DateTime CreateDate { get; set; }
            public string BreweryId { get; set; }
            public Brewery Brewery { get; set; }
        }

    }
}
