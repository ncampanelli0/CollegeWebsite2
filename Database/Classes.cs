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

        
        [BsonElement("Attendance")]
        public BsonArray Attendance { get; set; } = null;

        [BsonElement("Enrolled")]
        public BsonArray Enrolled {get; set; } = null;

        [BsonElement("AttendanceDate")]
        public BsonArray? AttendanceDate {get; set; } = null;

        [BsonElement("CourseName")]
        public string CourseName {get; set;} = null;

        [BsonElement("Crn")]
        public string CRN {get; set;} = null;

        [BsonElement("Prerequiste")]
        public string[]? Prerequiste {get; set; } = null;

        [BsonElement("MinimumRequirement")]
        public string[]? MinimumRequirements {get; set; } = null;

        [BsonElement("Description")]
        public string? Description {get; set; }

        [BsonElement("RoomID")]
        public int? RoomID { get; set; } = null;

        [BsonElement("BuildingID")]
        public int? BuildingID { get; set; } = null;

        [BsonElement("Type")]
        public string? Type {get; set;} = null;

        [BsonElement("TimeSlot")]
        public int? TimeSlot {get; set; } = null;

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

        [BsonElement("Year")]
        public int? Year { get; set; } = null;

        [BsonElement("Season")]
        public string? Season {get; set;} = null;

        [BsonElement("StartDate")]
        public string? StartDate {get; set;} = null;

        [BsonElement("EndDate")]
        public string? EndDate {get; set;} = null;

        [BsonElement("Time")]
        public ObjectId Time { get; set; }

    }
}