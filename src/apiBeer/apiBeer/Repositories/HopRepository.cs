using api.brewerydb.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Repositories
{
    public class HopRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public HopRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }



        public async Task<HopsResponse> GetAsync(int? pageNumber)
        {
            return await _breweryDb.Hop.GetHopsAsync(pageNumber);
        }

        public async Task<HopResponse> GetByIdAsync(string id)
        {
            return await _breweryDb.Hop.GetByIdAsync(id);
        }
    }
}