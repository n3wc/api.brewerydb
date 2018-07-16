using System.Threading.Tasks;
using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;

namespace apiBeer.Repositories
{
    public class FeatureRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public FeatureRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }


        public async Task<FeaturesResponse> GetAsync(FeatureRequest request)
        {
            return await _breweryDb.Feature.GetFeaturedAsync(request);
        }

        public async Task<FeatureResponse> GetByDateAsync(string yearWeek)
        {
            return await _breweryDb.Feature.GetByDateAsync(yearWeek);
        }

        public async Task<FeatureResponse> GetCurrentlyFeaturedAsync()
        {
            return await _breweryDb.Feature.GetCurrentlyFeaturedAsync();
        }

    }


}