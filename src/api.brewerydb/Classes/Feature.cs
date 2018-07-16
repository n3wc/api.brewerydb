using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace api.brewerydb.Classes
{
    public class Feature
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public Feature(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path, FeatureRequest request = null)
        {
            return $"{_baseAddress}{path}?key={_key}{request?.ToString()}";
        }

        public async Task<FeaturesResponse> GetFeaturedAsync(FeatureRequest request)
        {

            var uri = RouteBuilder("features", request);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<FeaturesResponse>(jsonResult);

                return results;
            }
            return new FeaturesResponse() { Status = response.StatusCode.ToString() };
        }
        public async Task<FeatureResponse> GetCurrentlyFeaturedAsync()
        {

            var uri = RouteBuilder("featured");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<FeatureResponse>(jsonResult);

                return results;
            }
            return new FeatureResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<FeatureResponse> GetByDateAsync(string yearWeek)
        {

            var uri = RouteBuilder($"feature/{ WebUtility.UrlEncode(yearWeek)}");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<FeatureResponse>(jsonResult);

                return results;
            }
            return new FeatureResponse() { Status = response.StatusCode.ToString() };
        }
    }
}
