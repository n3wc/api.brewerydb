using api.brewerydb.Models.Response;
using apiBeer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Orchestrators
{
    public class IngredientOrchestrator
    {
        IngredientRepository _IngredientRepository = new IngredientRepository();

        public async Task<IngredientResponse> GetById(string id)
        {
            return await _IngredientRepository.GetByIdAsync(id);
        }
        public async Task<IngredientsResponse> GetAsync(int? pageNumber)
        {
            return await _IngredientRepository.GetAsync(pageNumber);
        }
    }
}