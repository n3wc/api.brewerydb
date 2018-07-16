using apiBeer.Repositories;
using System.Threading.Tasks;
using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;

namespace apiBeer.Orchestrators
{

    public class BeerOrchestrator
    {
        BeerRepository _beerRepository = new BeerRepository();

        public async Task<BeerResponse> GetById(string id, BeerRequestAdditionalData additionalData = null)
        {
            return await _beerRepository.GetByIdAsync(id, additionalData);
        }
        public async Task<BeersResponse> GetAsync(BeerRequest request)
        {
            return await _beerRepository.GetAsync(request);
        }

    }
}