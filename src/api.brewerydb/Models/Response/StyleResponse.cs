using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class StyleResponse : BaseResponse
    {
        public Style Data { get; set; }
    }
    public class StylesResponse : BaseResponseList
    {
        public List<Style> Data { get; set; }
    }
}
