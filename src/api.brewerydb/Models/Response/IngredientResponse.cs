using System;
using System.Collections.Generic;
using System.Text;

namespace api.brewerydb.Models.Response
{
    public class IngredientResponse : BaseResponse
    {
        public Ingredient Data { get; set; }
    }
    public class IngredientsResponse : BaseResponseList
    {
        public List<Ingredient> Data { get; set; }
    }
}
