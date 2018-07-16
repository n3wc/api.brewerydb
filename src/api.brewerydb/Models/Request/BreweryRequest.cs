using System;
using System.Net;
using System.Text;
namespace api.brewerydb.Models.Request
{
    public class BreweryRequest
    {
        public int? pageNumber { get; set; }
        public string name { get; set; }
        public string ids { get; set; }
        public string year { get; set; }
        public bool? isOrganic { get; set; }
        public bool? hasImages { get; set; }
        public int? established { get; set; }
        public DateTime? since { get; set; }
        public string status { get; set; }
        public SortOrder? order { get; set; }
        public Sort? sort { get; set; }
        public int? randomCount { get; set; }
        public BreweryRequestAdditionalData additionalData { get; set; }

        public enum SortOrder { name, description, website, established, mailingListUrl, isOrganic, status, createDate, updateDate, random };
        public enum Sort { ASC, DESC }

        public override string ToString()
        {
            var sb = new StringBuilder();

            Type type = typeof(BreweryRequest);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var val = property.GetValue(this, null);
                if (val == null) continue;
                if (val.GetType().Equals(typeof(BreweryRequestAdditionalData)))
                {
                    sb.Append(((BreweryRequestAdditionalData)val).ToString());
                }
                else
                {
                    sb.Append($"&{(property.Name == "pageNumber" ? "p" : property.Name)}={EncodeValue(val)}");
                }
            }

            return sb.ToString();
        }
        private string EncodeValue(object value)
        {
            if (value.GetType().Equals(typeof(bool)))
            {
                return (bool)value ? "Y" : "N";
            }
                
            return WebUtility.UrlEncode(value.ToString());
        }
    }

    public class BreweryRequestAdditionalData
    {
        public bool? withSocialAccounts { get; set; }
        public bool? withGuilds { get; set; }
        public bool? withLocations { get; set; }
        public bool? withAlternateNames { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            Type type = typeof(BreweryRequestAdditionalData);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var val = property.GetValue(this, null);
                if (val == null) continue;

                sb.Append($"&{property.Name}={((bool)val ? "Y" : "N")}");

            }

            return sb.ToString();
        }
    }
}
