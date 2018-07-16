using System.Threading.Tasks;
using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;

namespace apiBeer.Repositories
{
    public class BreweryRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public BreweryRepository() {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }



        public async Task<BreweriesResponse> GetAsync(BreweryRequest request)
        {
           return await _breweryDb.Brewery.GetBreweriesAsync(request);
        }

        public async Task<BreweryResponse> GetByIdAsync(string id, BreweryRequestAdditionalData additionalData = null)
        {
            return await _breweryDb.Brewery.GetByIdAsync(id, additionalData);
        }

    }


}