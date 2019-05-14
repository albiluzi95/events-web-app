using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events_app.Models.Repository
{
    public class MongoDbRepo
    {
        //The client that manage the connection
        public MongoClient Client;
        //The interface that manage the database
        public IMongoDatabase Db;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">Mongo server url</param>
        /// <param name="database">Database name</param>
        public MongoDbRepo()
        {
            string url = "mongodb://albi_luzi:albiluzi1@ds259253.mlab.com:59253/umbrella_shop";
            this.Client = new MongoClient(url);
            //if the database is not exist, creates the database
            string database = "umbrella_shop";
            this.Db = this.Client.GetDatabase(database);
        }
    }
}