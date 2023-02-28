using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;} = String.Empty;

        [BsonElement("Crn")]
        public string CRN {get; set;} = String.Empty;

        [BsonElement("CourseName")]
        public string CourseName {get; set;} = String.Empty;

        [BsonElement("Prerequiste")]
        public string[]? Prerequiste {get; set;}

        [BsonElement("Description")]
        public string[]? Description {get; set;}
        
        [BsonElement("Type")]
        public string Type {get; set;} = String.Empty;
        
        [BsonElement("Department")]
        public string Department {get; set;} = String.Empty;
        
        [BsonElement("MinimumRequirements")]
        public string[]? MinimumRequirements {get; set;}
        
        [BsonElement("Credits")]
        public int Credits {get; set;}
    }
}