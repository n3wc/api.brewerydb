using api.brewerydb.Models.Response;
using apiBeer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Orchestrators
{
    public class FermentableOrchestrator
    {
        FermentableRepository _FermentableRepository = new FermentableRepository();

        public async Task<FermentableResponse> GetById(string id)
        {
            return await _FermentableRepository.GetByIdAsync(id);
        }
        public async Task<FermentablesResponse> GetAsync(int? pageNumber)
        {
            return await _FermentableRepository.GetAsync(pageNumber);
        }
    }
}