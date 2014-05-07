using BusinessManager.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Business
{
    public static class BreedBO
    {
        public static string db_name = "felicis";
        private static string breed_collection = "breeds";
        public static string connstring = "mongodb://user:12345@ds037358.mongolab.com:37358/felicis";
       
        public static IEnumerable<BreedDataModel> GetAll()
        {
            var client = new MongoClient(connstring);
            var server = client.GetServer();
            var db = server.GetDatabase(db_name);
            MongoCollection<BreedDataModel> collection = db.GetCollection<BreedDataModel>(breed_collection);
            MongoCursor<BreedDataModel> breeds = collection.FindAll();
            IEnumerable<BreedDataModel> list = breeds.ToList<BreedDataModel>();
            return list;
        }

        public static IEnumerable<BreedDataModel> Search(string text)
        {           

            var client = new MongoClient(connstring);
            var server = client.GetServer();
            var db = server.GetDatabase(db_name);
            MongoCollection<BreedDataModel> collection = db.GetCollection<BreedDataModel>(breed_collection);

            var query =
                from c in collection.AsQueryable<BreedDataModel>()
                where c.name.EndsWith(text) || c.name.StartsWith(text) 
                select c;

            IEnumerable<BreedDataModel> list = query.ToList<BreedDataModel>();
            return list;

        }
    }
}
