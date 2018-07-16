using api.brewerydb.Models.Response;
using apiBeer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Orchestrators
{
    public class SocialSiteOrchestrator
    {
        SocialSiteRepository _SocialSiteRepository = new SocialSiteRepository();

        public async Task<SocialSiteResponse> GetById(string id)
        {
            return await _SocialSiteRepository.GetByIdAsync(id);
        }
        public async Task<SocialSitesResponse> GetAsync()
        {
            return await _SocialSiteRepository.GetAsync();
        }
    }
}