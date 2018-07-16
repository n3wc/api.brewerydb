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
    [RoutePrefix("api/fermentable")]
    public class FermentableController : ApiController
    {
        FermentableOrchestrator _FermentableOrchestrator = new FermentableOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<FermentablesResponse> Get([FromUri]int? pageNumber = 1)
        {
            return await _FermentableOrchestrator.GetAsync(pageNumber);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<FermentableResponse> Get(string id)
        {
            return await _FermentableOrchestrator.GetById(id);
        }

    }
}
