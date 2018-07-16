using api.brewerydb.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Repositories
{
    public class YeastRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public YeastRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }



        public async Task<YeastsResponse> GetAsync(int? pageNumber)
        {
            return await _breweryDb.Yeast.GetYeastsAsync(pageNumber);
        }

        public async Task<YeastResponse> GetByIdAsync(string id)
        {
            return await _breweryDb.Yeast.GetByIdAsync(id);
        }
    }
}