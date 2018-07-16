using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class HopResponse : BaseResponse
    {
        public Hop Data { get; set; }
    }
    public class HopsResponse : BaseResponseList
    {
        public List<Hop> Data { get; set; }
    }
}
