using api.brewerydb.Models.Response;
using apiBeer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Orchestrators
{
    public class HopOrchestrator
    {
        HopRepository _HopRepository = new HopRepository();

        public async Task<HopResponse> GetById(string id)
        {
            return await _HopRepository.GetByIdAsync(id);
        }
        public async Task<HopsResponse> GetAsync(int? pageNumber)
        {
            return await _HopRepository.GetAsync(pageNumber);
        }
    }
}