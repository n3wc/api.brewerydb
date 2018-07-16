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
    public class Style
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public Style(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path)
        {
            return $"{_baseAddress}{path}?key={_key}";
        }

        public async Task<StylesResponse> GetStylesAsync()
        {

            var uri = RouteBuilder("styles");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<StylesResponse>(jsonResult);

                return results;
            }
            return new StylesResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<StyleResponse> GetByIdAsync(string id)
        {

            var uri = RouteBuilder($"style/{ WebUtility.UrlEncode(id)}");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<StyleResponse>(jsonResult);

                return results;
            }
            return new StyleResponse() { Status = response.StatusCode.ToString() };
        }

    }
}
