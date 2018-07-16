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
    [RoutePrefix("api/hop")]
    public class HopController : ApiController
    {
        HopOrchestrator _HopOrchestrator = new HopOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<HopsResponse> Get([FromUri]int? pageNumber = 1)
        {
            return await _HopOrchestrator.GetAsync(pageNumber);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<HopResponse> Get(string id)
        {
            return await _HopOrchestrator.GetById(id);
        }

    }
}
