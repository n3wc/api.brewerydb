using api.brewerydb.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Repositories
{
    public class StyleRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public StyleRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }

        public async Task<StylesResponse> GetAsync()
        {
            return await _breweryDb.Style.GetStylesAsync();
        }

        public async Task<StyleResponse> GetByIdAsync(string id)
        {
            return await _breweryDb.Style.GetByIdAsync(id);
        }
    }
}