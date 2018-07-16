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
    [RoutePrefix("api/yeast")]
    public class YeastController : ApiController
    {
        YeastOrchestrator _yeastOrchestrator = new YeastOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<YeastsResponse> Get([FromUri]int? pageNumber = 1)
        {
            return await _yeastOrchestrator.GetAsync(pageNumber);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<YeastResponse> Get(string id)
        {
            return await _yeastOrchestrator.GetById(id);
        }

    }
}
