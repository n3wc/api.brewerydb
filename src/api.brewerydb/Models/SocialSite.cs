using System;

namespace api.brewerydb.Models
{
    public class SocialSite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string HandleDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
