using BusinessManager.Models;
using BusinessManager.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Business
{
    public static class RecipeBO
    {
        public static IEnumerable<RecipeDataModel> GetAll()
        {
            return RecipeDAL.GetAll();
        }
    }
}
