using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class GradCourses
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("CourseName")]
        public string CourseName {get; set;} = String.Empty;

        [BsonElement("Type")]
        public string Type {get; set;} = String.Empty;

        [BsonElement("Department")]
        public string Department {get; set;} = String.Empty;

        [BsonElement("Description")]
        public string[]? Description {get; set;}

        [BsonElement("Crn")]
        public string CRN {get; set;} = String.Empty;

        [BsonElement("MinimumRequirements")]
        public string[]? MinimumRequirements {get; set;}

        [BsonElement("Prerequiste")]
        public string[]? Prerequiste {get; set;}
    }
}