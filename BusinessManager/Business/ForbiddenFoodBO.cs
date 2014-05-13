using BusinessManager.Models;
using BusinessManager.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Business
{
    public static class ForbiddenFoodBO
    {
        public static IEnumerable<ForbiddenFoodDataModel> GetAll()
        {
            return ForbiddenFoodDAL.GetAll();
        }
    }
}
