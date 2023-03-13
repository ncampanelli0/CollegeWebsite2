using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Database
{
    public class Classes
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("Grades")]
        public BsonArray Grades { get; set; } = null;

        [BsonElement("CRN")]
        public int? CRN {get; set; } 

        [BsonElement("Attendance")]
        public BsonArray Attendance { get; set; } = null;

        [BsonElement("Enrolled")]
        public BsonArray Enrolled {get; set; } = null;

        [BsonElement("AttendanceDate")]
        public BsonArray? AttendanceDate {get; set; } = null;

        [BsonElement("CourseName")]
        public string CourseName {get; set;} = null;

        [BsonElement("PotentialID")]
        public string PotentialID {get; set;} = null;

        [BsonElement("Section")]
        public string? Section {get; set;} 

        [BsonElement("Prerequiste")]
        public BsonArray? Prerequiste {get; set; } = null;

        [BsonElement("MinimumRequirement")]
        public BsonArray? MinimumRequirements {get; set; } = null;

        [BsonElement("Description")]
        public string? Description {get; set; }

        [BsonElement("RoomID")]
        public int? RoomID { get; set; } = null;

        [BsonElement("BuildingID")]
        public int? BuildingID { get; set; } = null;

        [BsonElement("Type")]
        public string? Type {get; set;} = null;

        [BsonElement("Credits")]
        public int? Credits {get; set; } = null;

        [BsonElement("MaxCapacity")]
        public int MaxCapacity { get; set; } = 0;

        [BsonElement("Day")]
        public string? Day {get; set;} = null;

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Professor")]
        public string? Professor {get; set;} = null;

        [BsonElement("Department")]
        public string? Department {get; set;} = null;

        [BsonElement("Time")]
        public ObjectId Time { get; set; }

    }
}