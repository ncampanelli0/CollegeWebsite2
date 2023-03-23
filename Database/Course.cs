using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Database
{
    public class Course
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("Crn")]
        public string? CRN {get; set;} = null;

        [BsonElement("CourseName")]
        public string CourseName {get; set;}

        [BsonElement("Prerequiste")]
        public BsonArray? Prerequiste { get; set; } = null;

        [BsonElement("Description")]
        public string Description { get; set; }
        
        [BsonElement("Type")]
        public string Type {get; set;}
        
        [BsonElement("Department")]
        public string Department {get; set;}
        
        [BsonElement("MinimumRequirements")]
        public BsonArray? MinimumRequirements {get; set;}
        
        [BsonElement("Credits")]
        public int Credits {get; set;}

        [BsonElement("CourseID")]
        public int CourseID { get; set; }
    }
}