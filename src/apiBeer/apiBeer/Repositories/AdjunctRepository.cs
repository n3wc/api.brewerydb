using api.brewerydb.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Repositories
{
    public class AdjunctRepository
    {
        private api.brewerydb.BreweryDb _breweryDb;
        public AdjunctRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }



        public async Task<AdjunctsResponse> GetAsync(int? pageNumber)
        {
            return await _breweryDb.Adjunct.GetAdjunctsAsync(pageNumber);
        }

        public async Task<AdjunctResponse> GetByIdAsync(string id)
        {
            return await _breweryDb.Adjunct.GetByIdAsync(id);
        }
    }
}