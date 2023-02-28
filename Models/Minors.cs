using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class Minors
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;} = String.Empty;

        [BsonElement("Minor")]
        public string Minor {get; set;} = String.Empty;

        [BsonElement("MinorRequirements")]
        public string[]? MinorRequirements {get; set;} 
    }
}