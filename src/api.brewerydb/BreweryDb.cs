using api.brewerydb.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace api.brewerydb
{
    public class BreweryDb
    {
        static readonly HttpClient _client = new HttpClient();
        private static readonly string _baseAddress = "http://api.brewerydb.com/v2/";
        private readonly string _key;

        public BreweryDb(string key) {
            _key = key;
            Adjunct = new Adjunct(_client, _baseAddress, _key);
            Brewery = new Brewery(_client, _baseAddress, _key);
            Yeast = new Yeast(_client, _baseAddress, _key);
            Style = new Style(_client, _baseAddress, _key);
            SocialSite = new SocialSite(_client, _baseAddress, _key);
            Ingredient = new Ingredient(_client, _baseAddress, _key);
            Hop = new Hop(_client, _baseAddress, _key);
            BeerCategory = new BeerCategory(_client, _baseAddress, _key);
            Beer = new Beer(_client, _baseAddress, _key);
            Feature = new Feature(_client, _baseAddress, _key);
            Fermentable = new Fermentable(_client, _baseAddress, _key);
        }
        public Adjunct Adjunct { get; }
        public Beer Beer { get; }
        public BeerCategory BeerCategory { get; }
        public Brewery Brewery { get; }
        public Feature Feature { get; }
        public Fermentable Fermentable { get; }
        public Ingredient Ingredient { get; }
        public Hop Hop { get; }
        public SocialSite SocialSite { get; }
        public Style Style { get; }
        public Yeast Yeast { get; }

    }
}
