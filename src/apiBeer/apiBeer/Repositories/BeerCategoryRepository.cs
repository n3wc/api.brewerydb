using api.brewerydb.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Repositories
{
    public class BeerCategoryRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public BeerCategoryRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }

        public async Task<BeerCategoriesResponse> GetAsync()
        {
            return await _breweryDb.BeerCategory.GetBeerCategorysAsync();
        }

        public async Task<BeerCategoryResponse> GetByIdAsync(string id)
        {
            return await _breweryDb.BeerCategory.GetByIdAsync(id);
        }
    }
}