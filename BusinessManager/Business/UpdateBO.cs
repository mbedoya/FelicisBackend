using BusinessManager.Models;
using BusinessManager.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Business
{
    public static class UpdateBO
    {
        public static IEnumerable<UpdateDataModel> GetAll()
        {
            return UpdateDAL.GetAll();
        }

        public static IEnumerable<UpdateDataModel> Search(int updatesApplied)
        {
            return UpdateDAL.Search(updatesApplied);
        }
    }
}
