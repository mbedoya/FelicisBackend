using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Models.DAL
{
    public static class ProfileDAL
    {
        public static ProfileDataModel Get(string email, string password)
        {
            var client = new MongoClient(BaseDAL.connstring);
            var server = client.GetServer();
            var db = server.GetDatabase(BaseDAL.db_name);
            MongoCollection<ProfileDataModel> collection = db.GetCollection<ProfileDataModel>(BusinessManager.Models.DAL.BaseDAL.Collections.profiles.ToString());

            var query =
                collection.AsQueryable<ProfileDataModel>()
                .Where(c => c.email.ToLower() == email.ToLower() && c.password == password);               

            List<ProfileDataModel> list = query.ToList<ProfileDataModel>();
            if (list.Count > 0){
                return list[0];
            }

            return new ProfileDataModel();
        }

        public static ProfileDataModel Get(string email)
        {
            var client = new MongoClient(BaseDAL.connstring);
            var server = client.GetServer();
            var db = server.GetDatabase(BaseDAL.db_name);
            MongoCollection<ProfileDataModel> collection = db.GetCollection<ProfileDataModel>(BusinessManager.Models.DAL.BaseDAL.Collections.profiles.ToString());

            var query =
                collection.AsQueryable<ProfileDataModel>()
                .Where(c => c.email.ToLower() == email.ToLower());

            List<ProfileDataModel> list = query.ToList<ProfileDataModel>();
            if (list.Count > 0)
            {
                return list[0];
            }

            return new ProfileDataModel();
        }

        public static ProfileDataModel Create(ProfileDataModel profile)
        {
            return BaseDAL.Create<ProfileDataModel>(profile, BaseDAL.Collections.profiles);          
        }
    }
}
