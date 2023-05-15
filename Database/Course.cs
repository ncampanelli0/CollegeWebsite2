using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Database
{
    public class Course
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("CourseName")]
        public string CourseName { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("Department")]
        public string Department { get; set; }

        [BsonElement("Credits")]
        public int Credits { get; set; }

        [BsonElement("CourseID")]
        public int CourseID { get; set; }

        [BsonElement("SectionCounter")]
        public int SectionCounter { get; set; }

        public List<Prerequiste>? Prerequiste { get; set; } = null;

    }

    public class Prerequiste
    {

        [BsonElement("Prereq")]
        public string Prereq { get; set; }

        [BsonElement("MinimumRequirements")]
        public string MinimumRequirements { get; set; }
    }


}