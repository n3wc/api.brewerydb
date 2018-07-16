using System.Collections.Generic;

namespace api.brewerydb.Models.Response
{
    public class BreweryResponse : BaseResponse
    {
        public Brewery Data { get; set; }

    }
    public class BreweriesResponse : BaseResponseList

    {
        public List<Brewery> Data { get; set; }
    }
}