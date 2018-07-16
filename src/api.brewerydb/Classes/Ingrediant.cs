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
    public class Ingredient
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public Ingredient(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path, int? pageNumber = 1)
        {
            return $"{_baseAddress}{path}?key={_key}&p={pageNumber}";
        }

        public async Task<IngredientsResponse> GetIngredientsAsync(int? pageNumber)
        {

            var uri = RouteBuilder("ingredients", pageNumber);
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<IngredientsResponse>(jsonResult);

                return results;
            }
            return new IngredientsResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<IngredientResponse> GetByIdAsync(string id)
        {

            var uri = RouteBuilder($"ingredient/{ WebUtility.UrlEncode(id)}");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<IngredientResponse>(jsonResult);

                return results;
            }
            return new IngredientResponse() { Status = response.StatusCode.ToString() };
        }

    }
}