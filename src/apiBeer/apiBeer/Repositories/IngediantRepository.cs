using api.brewerydb.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Repositories
{
    public class IngredientRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public IngredientRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }



        public async Task<IngredientsResponse> GetAsync(int? pageNumber)
        {
            return await _breweryDb.Ingredient.GetIngredientsAsync(pageNumber);
        }

        public async Task<IngredientResponse> GetByIdAsync(string id)
        {
            return await _breweryDb.Ingredient.GetByIdAsync(id);
        }
    }
}