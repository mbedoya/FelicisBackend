using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Models.DAL
{
    public static class RecipeDAL
    {
        public static IEnumerable<RecipeDataModel> GetAll()
        {
            return BaseDAL.GetAll<RecipeDataModel>(BusinessManager.Models.DAL.BaseDAL.Collections.recipes);
        }
    }
}
