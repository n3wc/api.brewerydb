using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class FeatureResponse : BaseResponse
    {
        public Feature Data { get; set; }
    }
    public class FeaturesResponse : BaseResponseList
    {
        public List<Feature> Data { get; set; }
    }
}
