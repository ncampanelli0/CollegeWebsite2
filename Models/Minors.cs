using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class Minors
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("Minor")]
        public string Minor {get; set;}

        [BsonElement("MinorRequirements")]
        public string[]? MinorRequirements {get; set;} 
    }
}