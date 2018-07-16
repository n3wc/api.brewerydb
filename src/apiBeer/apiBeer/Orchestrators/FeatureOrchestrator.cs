using apiBeer.Repositories;
using System.Threading.Tasks;
using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;

namespace apiBeer.Orchestrators
{

    public class FeatureOrchestrator
    {
        FeatureRepository _featureRepository = new FeatureRepository();

        public async Task<FeatureResponse> GetByDateAsync(string yearWeek)
        {
            return await _featureRepository.GetByDateAsync(yearWeek);
        }
        public async Task<FeatureResponse> GetCurrentlyFeaturedAsync()
        {
            return await _featureRepository.GetCurrentlyFeaturedAsync();
        }
        
        public async Task<FeaturesResponse> GetAsync(FeatureRequest request)
        {
            return await _featureRepository.GetAsync(request);
        }

    }
}