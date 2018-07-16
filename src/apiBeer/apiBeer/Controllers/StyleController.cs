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
    [RoutePrefix("api/style")]
    public class StyleController : ApiController
    {
        StyleOrchestrator _StyleOrchestrator = new StyleOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<StylesResponse> Get()
        {
            return await _StyleOrchestrator.GetAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<StyleResponse> Get(string id)
        {
            return await _StyleOrchestrator.GetById(id);
        }

    }
}
