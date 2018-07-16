using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class AdjunctResponse : BaseResponse
    {
        public Adjunct Data { get; set; }
    }
    public class AdjunctsResponse : BaseResponseList
    {
        public List<Adjunct> Data { get; set; }
    }
}
