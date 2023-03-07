using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2
{
    public class Department
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("Departments")]
        public string Departments {get; set;} = String.Empty;

        [BsonElement("CrnPrefix")]
        public string CRNPrefix {get; set;} = String.Empty;
    }
}