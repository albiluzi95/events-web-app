using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events_app.Models
{
    public class Event
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public int price { get; set; }
        public string imageUrl { get; set; }
        public Location location { get; set; }
        public string onlineUrl { get; set; }
        public List<Session> sessions { get; set; }

        public class Location
        {
            public string address { get; set; }
            public string city { get; set; }
            public string country { get; set; }

        }
    }

    public class Session
    {
        public int id { get; set; }
        public string name { get; set; }
        public string presenter { get; set; }
        public int duration { get; set; }
        public string level { get; set; }
        public string abstr { get; set; }
        public string[] voters { get; set; }
    }
}