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
    [RoutePrefix("api/ingredient")]
    public class IngredientController : ApiController
    {
        IngredientOrchestrator _IngredientOrchestrator = new IngredientOrchestrator();

        [HttpGet]
        [Route("")]
        public async Task<IngredientsResponse> Get([FromUri]int? pageNumber = 1)
        {
            return await _IngredientOrchestrator.GetAsync(pageNumber);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IngredientResponse> Get(string id)
        {
            return await _IngredientOrchestrator.GetById(id);
        }

    }
}
