using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Database
{
    public class Departments
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("Department")]
        public string Department {get; set;}

        [BsonElement("CrnPrefix")]
        public string CRNPrefix {get; set;}
    }
}