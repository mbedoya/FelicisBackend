using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Models.DAL
{
    public static class UpdateDAL
    {
        public static IEnumerable<UpdateDataModel> GetAll()
        {
            return BaseDAL.GetAll<UpdateDataModel>(BusinessManager.Models.DAL.BaseDAL.Collections.updates);           
        }

        public static IEnumerable<UpdateDataModel> Search(int updatesApplied)
        {
            var client = new MongoClient(BaseDAL.connstring);
            var server = client.GetServer();
            var db = server.GetDatabase(BaseDAL.db_name);
            MongoCollection<UpdateDataModel> collection = db.GetCollection<UpdateDataModel>(BusinessManager.Models.DAL.BaseDAL.Collections.updates.ToString());

            var query =
                collection.AsQueryable<UpdateDataModel>()
                .OrderBy(c => c.id)
                .Skip(updatesApplied);

            IEnumerable<UpdateDataModel> list = query.ToList<UpdateDataModel>();
            return list;
        }
    }
}
