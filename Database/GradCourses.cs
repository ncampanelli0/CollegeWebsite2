using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Database
{
    public class GradCourses
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("Crn")]
        public string? CRN { get; set; } = null;

        [BsonElement("CourseName")]
        public string CourseName { get; set; }

        [BsonElement("Prerequiste")]
        public string[]? Prerequiste { get; set; } = null;

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("Department")]
        public string Department { get; set; }

        [BsonElement("MinimumRequirements")]
        public string[]? MinimumRequirements { get; set; }

        [BsonElement("Credits")]
        public int Credits { get; set; }
    }
}