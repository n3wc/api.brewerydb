using api.brewerydb.Models.Response;
using apiBeer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Orchestrators
{
    public class BeerCategoryOrchestrator
    {
        BeerCategoryRepository _BeerCategoryRepository = new BeerCategoryRepository();

        public async Task<BeerCategoryResponse> GetById(string id)
        {
            return await _BeerCategoryRepository.GetByIdAsync(id);
        }
        public async Task<BeerCategoriesResponse> GetAsync()
        {
            return await _BeerCategoryRepository.GetAsync();
        }
    }
}