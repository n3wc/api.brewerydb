using apiBeer.Repositories;
using System.Threading.Tasks;
using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;

namespace apiBeer.Orchestrators
{

    public class BreweryOrchestrator
    {
        BreweryRepository _breweryRepository = new BreweryRepository();

        public async Task<BreweryResponse> GetById(string id, BreweryRequestAdditionalData additionalData = null) {
            return await _breweryRepository.GetByIdAsync(id, additionalData);
        }
        public async Task<BreweriesResponse> GetAsync(BreweryRequest request)
        {
            return await _breweryRepository.GetAsync(request);
        }
        
    }
}