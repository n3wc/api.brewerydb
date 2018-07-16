using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class YeastResponse : BaseResponse
    {
        public Yeast Data { get; set; }
    }
    public class YeastsResponse : BaseResponseList
    {
        public List<Yeast> Data { get; set; }
    }
}
