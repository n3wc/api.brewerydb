using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class BeerResponse : BaseResponse
    {
        public Beer Data { get; set; }
    }
    public class BeersResponse : BaseResponseList
    {
        public List<Beer> Data { get; set; }
    }
}
