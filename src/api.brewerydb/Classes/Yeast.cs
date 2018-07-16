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
    public class Yeast
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public Yeast(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path, int? pageNumber = 1)
        {
            return $"{_baseAddress}{path}?key={_key}&p={pageNumber}";
        }

        public async Task<YeastsResponse> GetYeastsAsync(int? pageNumber)
        {

            var uri = RouteBuilder("yeasts", pageNumber);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<YeastsResponse>(jsonResult);

                return results;
            }
            return new YeastsResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<YeastResponse> GetByIdAsync(string id)
        {

            var uri = RouteBuilder($"yeast/{ WebUtility.UrlEncode(id)}");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<YeastResponse>(jsonResult);

                return results;
            }
            return new YeastResponse() { Status = response.StatusCode.ToString() };
        }

    }
}
