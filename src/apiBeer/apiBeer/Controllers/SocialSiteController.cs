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
    [RoutePrefix("api/socialsite")]
    public class SocialSiteController : ApiController
    {
        SocialSiteOrchestrator _SocialSiteOrchestrator = new SocialSiteOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<SocialSitesResponse> Get()
        {
            return await _SocialSiteOrchestrator.GetAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<SocialSiteResponse> Get(string id)
        {
            return await _SocialSiteOrchestrator.GetById(id);
        }

    }
}
