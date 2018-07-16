using api.brewerydb.Models.Response;
using apiBeer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Orchestrators
{
    public class YeastOrchestrator
    {
        YeastRepository _yeastRepository = new YeastRepository();

        public async Task<YeastResponse> GetById(string id)
        {
            return await _yeastRepository.GetByIdAsync(id);
        }
        public async Task<YeastsResponse> GetAsync(int? pageNumber)
        {
            return await _yeastRepository.GetAsync(pageNumber);
        }
    }
}