using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public abstract class BaseResponse
    {
        public string Message { get; set; }
        public string Status { get; set; }
    }
    public abstract class BaseResponseList
    {
        public int CurrentPage { get; set; }
        public int NumberOfPages { get; set; }
        public int TotalResults { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
}
