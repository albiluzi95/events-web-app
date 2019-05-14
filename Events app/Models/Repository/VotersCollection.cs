using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events_app.Models.Repository
{
    public class VotersCollection
    {
        internal MongoDbRepo _repo = new MongoDbRepo();
        //Contains all documents inside the collection
        public IMongoCollection<Event> Collection;

        //Constructor
        public VotersCollection()
        {
            Collection = _repo.Db.GetCollection<Event>("voters");
        }

        public bool AddVoter(int eventid,int SessionId, string VoterName)
        {
            List<Event> events = Collection.Find(new BsonDocument()).ToListAsync().Result;
            Event @event = events.Where(e => e.id ==eventid).FirstOrDefault();
            Session session = @event.sessions.Where(s => s.id == SessionId).FirstOrDefault();
            session.voters = session.voters.Where(val => val != VoterName).ToArray();

            return true;
        }
    }
}