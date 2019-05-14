using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events_app.Models
{
    public class User
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
}