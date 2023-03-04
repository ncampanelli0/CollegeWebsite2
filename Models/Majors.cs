using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class Majors
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id {get; set;}

        [BsonElement("Major")]
        public string Major {get; set;} = String.Empty;

        [BsonElement("MajorRequirements")]
        public string[]? MajorRequirements {get; set;} 
    }
}