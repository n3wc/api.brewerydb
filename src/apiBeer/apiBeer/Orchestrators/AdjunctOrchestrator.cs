using api.brewerydb.Models.Response;
using apiBeer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Orchestrators
{
    public class AdjunctOrchestrator
    {
        AdjunctRepository _adjunctRepository = new AdjunctRepository();

        public async Task<AdjunctResponse> GetById(string id)
        {
            return await _adjunctRepository.GetByIdAsync(id);
        }
        public async Task<AdjunctsResponse> GetAsync(int? pageNumber)
        {
            return await _adjunctRepository.GetAsync(pageNumber);
        }
    }
}