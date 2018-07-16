using apiBeer.Orchestrators;
using System.Web.Http;
using System.Threading.Tasks;
using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;

namespace apiBeer.Controllers
{
    [RoutePrefix("api/beer")]
    public class BeerController : ApiController
    {
        BeerOrchestrator _beerOrchestrator = new BeerOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<BeersResponse> Get([FromUri]BeerRequest request)
        {
            return await _beerOrchestrator.GetAsync(request);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<BeerResponse> Get(string id, [FromUri] BeerRequestAdditionalData additionalData)
        {
            return await _beerOrchestrator.GetById(id, additionalData);
        }


    }
}
