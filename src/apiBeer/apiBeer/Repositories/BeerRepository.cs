using System.Threading.Tasks;
using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;

namespace apiBeer.Repositories
{
    public class BeerRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public BeerRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }



        public async Task<BeersResponse> GetAsync(BeerRequest request)
        {
            return await _breweryDb.Beer.GetBeersAsync(request);
        }

        public async Task<BeerResponse> GetByIdAsync(string id, BeerRequestAdditionalData additionalData = null)
        {
            return await _breweryDb.Beer.GetByIdAsync(id, additionalData);
        }

    }


}