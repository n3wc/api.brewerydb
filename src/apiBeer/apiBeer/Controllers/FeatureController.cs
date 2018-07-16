using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;
using apiBeer.Orchestrators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace apiBeer.Controllers
{
    [RoutePrefix("api/feature")]
    public class FeatureController : ApiController
    {
        FeatureOrchestrator _FeatureOrchestrator = new FeatureOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<FeaturesResponse> Get([FromUri]FeatureRequest request)
        {
            return await _FeatureOrchestrator.GetAsync(request);
        }

        [HttpGet]
        [Route("{yearWeek}")]
        public async Task<FeatureResponse> GetByDate(string yearWeek)
        {
            return await _FeatureOrchestrator.GetByDateAsync(yearWeek);
        }
        [HttpGet]
        [Route("featured")]
        public async Task<FeatureResponse> GetCurrentlyFeatured()
        {
            return await _FeatureOrchestrator.GetCurrentlyFeaturedAsync();
        }

    }
}
