using System;
using System.Net;
using System.Text;
namespace api.brewerydb.Models.Request
{
    public class FeatureRequest
    {
        public int? pageNumber { get; set; }
        public string year { get; set; }
        public string week { get; set; }
        public bool? ignoreFuture { get; set; }
        
        public override string ToString()
        {
            var sb = new StringBuilder();

            Type type = typeof(FeatureRequest);
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                var val = property.GetValue(this, null);
                if (val == null) continue;

                sb.Append($"&{(property.Name == "pageNumber" ? "p" : property.Name)}={EncodeValue(val)}");

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
}
