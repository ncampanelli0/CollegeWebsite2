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
        public int CRN {get; set; } 

        [BsonElement("Attendance")]
        public BsonArray Attendance { get; set; } = null;

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
        public int RoomID { get; set; }

        [BsonElement("BuildingID")]
        public int BuildingID { get; set; }

        [BsonElement("Type")]
        public string? Type {get; set;} = null;

        [BsonElement("Credits")]
        public int Credits {get; set; }

        [BsonElement("MaxCapacity")]
        public int MaxCapacity { get; set; } = 0;

        [BsonElement("Day")]
        public string? Day {get; set;} = null;

        [BsonElement("Professor")]
        public ObjectId? Professor {get; set;} = null;

        [BsonElement("Department")]
        public String? Department {get; set;} = null;

        [BsonElement("Time ID")]
        public ObjectId TimeID { get; set; }

        [BsonElement("Semester")]
        public string Semester { get; set; }

        [BsonElement("Period")]
        public string Period { get; set; }

        [BsonElement("StartDate")]
        public DateTime StartDate { get; set; }

        [BsonElement("EndDate")]
        public DateTime EndDate { get; set; }

        [BsonElement("RegistrationLimit")]
        public DateTime RegistrationLimit { get; set; }

        [BsonElement("WithdrawLimit")]
        public DateTime WithdrawLimit { get; set; }

        [BsonElement("GradeLimit")]
        public DateTime GradeLimit { get; set; }

        [BsonElement("ProfessorName")]
        public string ProfessorName { get; set; }

        [BsonElement("CourseID")]
        public int CourseID { get; set; }

        [BsonElement("ProfFirstName")] 
        public string? ProfFirstName {get; set;} = null; 
        
        [BsonElement("ProfLastName")]
        public string? ProfLastName {get; set;} = null;

        [BsonElement("Enrolled")]
        public List<string>? Enrolled { get; set; } = null;

    }
}