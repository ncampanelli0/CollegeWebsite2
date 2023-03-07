using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class Classes
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id {get; set;}

        [BsonElement("Grades")]
        public string[]? Grades {get; set;}

        [BsonElement("Attendance")]
        public string[]? Attendance {get; set;}

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Enrolled")]
        public string[]? Enrolled {get; set;}

        [BsonElement("AttendanceDate")]
        public string[]? AttendanceDate {get; set;}

        [BsonElement("CourseName")]
        public string CourseName {get; set;} = String.Empty;

        [BsonElement("Crn")]
        public string CRN {get; set;} = String.Empty;

        [BsonElement("Prerequiste")]
        public string[]? Prerequiste {get; set;}

        [BsonElement("MinimumRequirement")]
        public string[]? MinimumRequirements {get; set;}

        [BsonElement("Description")]
        public string[]? Description {get; set;}

        [BsonElement("RoomID")]
        public int RoomID {get; set;}

        [BsonElement("BuildingID")]
        public int BuildingID {get; set;}

        [BsonElement("Type")]
        public string Type {get; set;} = String.Empty;

        [BsonElement("TimeSlot")]
        public int TimeSlot {get; set;}

        [BsonElement("Credits")]
        public int Credits {get; set;}

        [BsonElement("MaxCapacity")]
        public int MaxCapacity {get; set;}

        [BsonElement("Day")]
        public string Day {get; set;} = String.Empty;

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Professor")]
        public string Professor {get; set;} = String.Empty;

        [BsonElement("Department")]
        public string Department {get; set;} = String.Empty;
        
        [BsonElement("Year")]
        public int Year {get; set;}

        [BsonElement("Season")]
        public string Season {get; set;} = String.Empty;

        [BsonElement("StartDate")]
        public string StartDate {get; set;} = String.Empty;

        [BsonElement("EndDate")]
        public string EndDate {get; set;} = String.Empty;

    }
}