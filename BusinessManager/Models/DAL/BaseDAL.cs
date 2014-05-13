using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Models.DAL
{
    public static class BaseDAL
    {
        public static string db_name = "felicis";
        public static string connstring = "mongodb://user:12345@ds037358.mongolab.com:37358/felicis";

        public enum Collections
        {
            breeds,
            updates,
            recipes,
            profiles,
            forbiddenfood
        }

        public static IEnumerable<T> GetAll<T>(Collections collectionName)
        {
            var client = new MongoClient(connstring);
            var server = client.GetServer();
            var db = server.GetDatabase(db_name);
            MongoCollection<T> collection = db.GetCollection<T>(collectionName.ToString());
            MongoCursor<T> cursor = collection.FindAll();
            IEnumerable<T> list = cursor.ToList<T>();
            return list;
        }

        public static T Create<T>(T entity, Collections collectionName)
        {
            var client = new MongoClient(connstring);
            var server = client.GetServer();
            var db = server.GetDatabase(db_name);
            MongoCollection<T> collection = db.GetCollection<T>(collectionName.ToString());           
            WriteConcernResult result = collection.Insert(entity);
            return entity;
        }
    }
}
