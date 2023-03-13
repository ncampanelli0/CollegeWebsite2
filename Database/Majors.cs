using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Database
{
    public class Majors
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("Major")]
        public string Major {get; set;}

        [BsonElement("MajorRequirements")]
        public BsonArray? MajorRequirements {get; set;} 
    }
}