using System;

namespace api.brewerydb.Models
{
    public class SocialAccount
    {
        public int Id { get; set; }
        public int SocialMediaId { get; set; }
        public SocialSite SocialSite { get; set; }
        public string Handle { get; set; }
        public DateTime CreateDate { get; set; }
        public string Link { get; set; }
    }
}
