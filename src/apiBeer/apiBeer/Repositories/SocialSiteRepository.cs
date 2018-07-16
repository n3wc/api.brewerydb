using api.brewerydb.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace apiBeer.Repositories
{
    public class SocialSiteRepository
    {
        
        private api.brewerydb.BreweryDb _breweryDb;
        public SocialSiteRepository()
        {
            _breweryDb = new api.brewerydb.BreweryDb(WebApiConfig.BreweryDbKey);
        }

        public async Task<SocialSitesResponse> GetAsync()
        {
            return await _breweryDb.SocialSite.GetSocialSitesAsync();
        }

        public async Task<SocialSiteResponse> GetByIdAsync(string id)
        {
            return await _breweryDb.SocialSite.GetByIdAsync(id);
        }
    }
}