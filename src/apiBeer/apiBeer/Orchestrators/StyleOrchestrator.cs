using api.brewerydb.Models.Response;
using apiBeer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Orchestrators
{
    public class StyleOrchestrator
    {
        StyleRepository _StyleRepository = new StyleRepository();

        public async Task<StyleResponse> GetById(string id)
        {
            return await _StyleRepository.GetByIdAsync(id);
        }
        public async Task<StylesResponse> GetAsync()
        {
            return await _StyleRepository.GetAsync();
        }
    }
}