using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace api.brewerydb.Classes
{
    public class Brewery
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public Brewery(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path, BreweryRequest request = null, BreweryRequestAdditionalData additionalData = null)
        {
            return $"{_baseAddress}{path}?key={_key}{request?.ToString()}{additionalData?.ToString()}";
        }

        public async Task<BreweriesResponse> GetBreweriesAsync(BreweryRequest request)
        {

            var uri = RouteBuilder("breweries", request);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<BreweriesResponse>(jsonResult);

                return results;
            }
            return new BreweriesResponse() { Status = response.StatusCode.ToString()};
        }

        public async Task<BreweryResponse> GetByIdAsync(string id, BreweryRequestAdditionalData additionalData = null)
        {

            var uri = RouteBuilder($"brewery/{ WebUtility.UrlEncode(id)}",null, additionalData);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<BreweryResponse>(jsonResult);

                return results;
            }
            return new BreweryResponse() { Status = response.StatusCode.ToString() };
        }
    }
}
