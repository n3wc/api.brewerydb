using api.brewerydb.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Repositories
{
    public class FermentableRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public FermentableRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }



        public async Task<FermentablesResponse> GetAsync(int? pageNumber)
        {
            return await _breweryDb.Fermentable.GetFermentablesAsync(pageNumber);
        }

        public async Task<FermentableResponse> GetByIdAsync(string id)
        {
            return await _breweryDb.Fermentable.GetByIdAsync(id);
        }
    }
}