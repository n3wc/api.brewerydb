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
    [RoutePrefix("api/beercategory")]
    public class BeerCategoryController : ApiController
    {
        BeerCategoryOrchestrator _BeerCategoryOrchestrator = new BeerCategoryOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<BeerCategoriesResponse> Get()
        {
            return await _BeerCategoryOrchestrator.GetAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<BeerCategoryResponse> Get(string id)
        {
            return await _BeerCategoryOrchestrator.GetById(id);
        }

    }
}
