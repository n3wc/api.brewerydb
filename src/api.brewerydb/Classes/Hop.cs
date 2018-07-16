using api.brewerydb.Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace api.brewerydb.Classes
{
    public class Hop
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public Hop(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path, int? pageNumber = 1)
        {
            return $"{_baseAddress}{path}?key={_key}&p={pageNumber}";
        }

        public async Task<HopsResponse> GetHopsAsync(int? pageNumber)
        {

            var uri = RouteBuilder("hops", pageNumber);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<HopsResponse>(jsonResult);

                return results;
            }
            return new HopsResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<HopResponse> GetByIdAsync(string id)
        {

            var uri = RouteBuilder($"hop/{ WebUtility.UrlEncode(id)}");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<HopResponse>(jsonResult);

                return results;
            }
            return new HopResponse() { Status = response.StatusCode.ToString() };
        }

    }
}
