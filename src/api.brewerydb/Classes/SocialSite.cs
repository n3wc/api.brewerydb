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
    public class SocialSite
    {
        static HttpClient _client;
        private readonly string _baseAddress;
        private readonly string _key;

        public SocialSite(HttpClient client, string baseAddress, string key)
        {
            _client = client;
            _baseAddress = baseAddress;
            _key = key;
        }

        private string RouteBuilder(string path)
        {
            return $"{_baseAddress}{path}?key={_key}";
        }

        public async Task<SocialSitesResponse> GetSocialSitesAsync()
        {

            var uri = RouteBuilder("socialsites");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<SocialSitesResponse>(jsonResult);

                return results;
            }
            return new SocialSitesResponse() { Status = response.StatusCode.ToString() };
        }

        public async Task<SocialSiteResponse> GetByIdAsync(string id)
        {

            var uri = RouteBuilder($"socialsite/{ WebUtility.UrlEncode(id)}");
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<SocialSiteResponse>(jsonResult);

                return results;
            }
            return new SocialSiteResponse() { Status = response.StatusCode.ToString() };
        }

    }
}
