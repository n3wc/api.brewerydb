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
    public class Fermentable
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public Fermentable(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path, int? pageNumber = 1)
        {
            return $"{_baseAddress}{path}?key={_key}&p={pageNumber}";
        }

        public async Task<FermentablesResponse> GetFermentablesAsync(int? pageNumber)
        {

            var uri = RouteBuilder("fermentables", pageNumber);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<FermentablesResponse>(jsonResult);

                return results;
            }
            return new FermentablesResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<FermentableResponse> GetByIdAsync(string id)
        {

            var uri = RouteBuilder($"fermentable/{ WebUtility.UrlEncode(id)}");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<FermentableResponse>(jsonResult);

                return results;
            }
            return new FermentableResponse() { Status = response.StatusCode.ToString() };
        }

    }
}
