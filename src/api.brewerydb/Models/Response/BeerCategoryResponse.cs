using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class BeerCategoryResponse : BaseResponse
    {
        public BeerCategory Data { get; set; }
    }
    public class BeerCategoriesResponse : BaseResponseList
    {
        public List<BeerCategory> Data { get; set; }
    }
}
