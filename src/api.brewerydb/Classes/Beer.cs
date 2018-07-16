using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace api.brewerydb.Classes
{
    public class Beer
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public Beer(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path, BeerRequest request = null, BeerRequestAdditionalData additionalData = null)
        {
            return $"{_baseAddress}{path}?key={_key}{request?.ToString()}{additionalData?.ToString()}";
        }

        public async Task<BeersResponse> GetBeersAsync(BeerRequest request)
        {

            var uri = RouteBuilder("beers", request);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<BeersResponse>(jsonResult);

                return results;
            }
            return new BeersResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<BeerResponse> GetByIdAsync(string id, BeerRequestAdditionalData additionalData = null)
        {

            var uri = RouteBuilder($"beer/{ WebUtility.UrlEncode(id)}", null, additionalData);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<BeerResponse>(jsonResult);

                return results;
            }
            return new BeerResponse() { Status = response.StatusCode.ToString() };
        }
    }
}
