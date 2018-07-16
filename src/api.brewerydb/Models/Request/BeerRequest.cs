using System;
using System.Net;
using System.Text;
namespace api.brewerydb.Models.Request
{
    public class BeerRequest
    {
        public int? pageNumber { get; set; }
        public string name { get; set; }
        public string ids { get; set; }
        public string abv { get; set; }
        public string ibu { get; set; }
        public int? glasswareId { get; set; }
        public int? srmId { get; set; }
        public int? availableId { get; set; }
        public int? styleId { get; set; }
        public bool? hasLabels { get; set; }
        public string year { get; set; }
        public bool? isOrganic { get; set; }
        public bool? withBreweries { get; set; }
        public DateTime? since { get; set; }
        public string status { get; set; }
        public SortOrder? order { get; set; }
        public Sort? sort { get; set; }
        public int? randomCount { get; set; }
        public BeerRequestAdditionalData additionalData { get; set; }

        public enum SortOrder { name, description, abv, ibu, glasswareId, srmId, availableId, styleId, isOrganic, status, createDate, updateDate, random };
        public enum Sort { ASC, DESC }

        public override string ToString()
        {
            var sb = new StringBuilder();

            Type type = typeof(BeerRequest);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var val = property.GetValue(this, null);
                if (val == null) continue;
                if (val.GetType().Equals(typeof(BeerRequestAdditionalData)))
                {
                    sb.Append(((BeerRequestAdditionalData)val).ToString());
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

    public class BeerRequestAdditionalData
    {
        public bool? withSocialAccounts { get; set; }
        public bool? withIngredients { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            Type type = typeof(BeerRequestAdditionalData);
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
