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
    [RoutePrefix("api/adjunct")]
    public class AdjunctController : ApiController
    {
        AdjunctOrchestrator _adjunctOrchestrator = new AdjunctOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<AdjunctsResponse> Get([FromUri]int? pageNumber = 1)
        {
            return await _adjunctOrchestrator.GetAsync(pageNumber);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<AdjunctResponse> Get(string id)
        {
            return await _adjunctOrchestrator.GetById(id);
        }

    }
}
