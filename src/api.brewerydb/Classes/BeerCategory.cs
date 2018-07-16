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
    public class BeerCategory
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public BeerCategory(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path)
        {
            return $"{_baseAddress}{path}?key={_key}";
        }

        public async Task<BeerCategoriesResponse> GetBeerCategorysAsync()
        {

            var uri = RouteBuilder("categories");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<BeerCategoriesResponse>(jsonResult);
                return results;
            }
            return new BeerCategoriesResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<BeerCategoryResponse> GetByIdAsync(string id)
        {

            var uri = RouteBuilder($"category/{ WebUtility.UrlEncode(id)}");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<BeerCategoryResponse>(jsonResult);

                return results;
            }
            return new BeerCategoryResponse() { Status = response.StatusCode.ToString() };
        }

    }
}
