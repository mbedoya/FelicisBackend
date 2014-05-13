using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Models.DAL
{
    public static class ForbiddenFoodDAL
    {
        public static IEnumerable<ForbiddenFoodDataModel> GetAll()
        {
            return BaseDAL.GetAll<ForbiddenFoodDataModel>(BusinessManager.Models.DAL.BaseDAL.Collections.forbiddenfood);
        }
    }
}
