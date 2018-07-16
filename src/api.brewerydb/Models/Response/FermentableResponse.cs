using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class FermentableResponse : BaseResponse
    {
        public Fermentable Data { get; set; }
    }
    public class FermentablesResponse : BaseResponseList
    {
        public List<Fermentable> Data { get; set; }
    }
}
