using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class SocialSiteResponse : BaseResponse
    {
        public SocialSite Data { get; set; }
    }
    public class SocialSitesResponse : BaseResponseList
    {
        public List<SocialSite> Data { get; set; }
    }
}
