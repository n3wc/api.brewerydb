using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models
{
    public class Guild
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public Images Images { get; set; }
        public string Status { get; set; }
        public string StatusDisplay { get; set; }
        public string Established { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
