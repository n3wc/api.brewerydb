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
    public class Adjunct
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public Adjunct(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path, int? pageNumber = 1)
        {
            return $"{_baseAddress}{path}?key={_key}&p={pageNumber}";
        }

        public async Task<AdjunctsResponse> GetAdjunctsAsync(int? pageNumber)
        {

            var uri = RouteBuilder("adjuncts", pageNumber);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<AdjunctsResponse>(jsonResult);

                return results;
            }
            return new AdjunctsResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<AdjunctResponse> GetByIdAsync(string id)
        {

            var uri = RouteBuilder($"adjunct/{ WebUtility.UrlEncode(id)}");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<AdjunctResponse>(jsonResult);

                return results;
            }
            return new AdjunctResponse() { Status = response.StatusCode.ToString() };
        }

    }
}
