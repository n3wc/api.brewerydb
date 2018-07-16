using apiBeer.Orchestrators;
using System.Web.Http;
using System.Threading.Tasks;
using api.brewerydb.Models.Request;
using api.brewerydb.Models.Response;

namespace apiBeer.Controllers
{
    [RoutePrefix("api/brewery")]
    public class BreweryController : ApiController
    {
        BreweryOrchestrator _breweryOrchestrator = new BreweryOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<BreweriesResponse> Get([FromUri]BreweryRequest request) {
            return await _breweryOrchestrator.GetAsync(request);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<BreweryResponse> Get(string id, [FromUri] BreweryRequestAdditionalData additionalData)
        {
            return await _breweryOrchestrator.GetById(id, additionalData);
        }


        // POST: api/Brewery
        public string Post([FromBody]string value)
        {
            return $"value - {value}";
        }

        // PUT: api/Brewery/5
        public string Put(int id, [FromBody]string value)
        {
            return $"{id} - {value}";
        }

        // DELETE: api/Brewery/5
        public string Delete(int id)
        {
            return $"delete - {id}";
        }
    }
}
