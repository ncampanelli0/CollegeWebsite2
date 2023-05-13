using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Reflection.Metadata;

namespace CollegeWebsite2.Database
{
    public class AllUser
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("Major")]
        public string? Major { get; set; } = null;

        [BsonElement("Minor")]
        public string? Minor { get; set; } = null;

        [BsonElement("FirstName")]
        public string? FirstName { get; set; } = null;

        [BsonElement("LastName")]
        public string? LastName { get; set; } = null;

        [BsonElement("Birthday")]
        public DateTime Birthday { get; set; }

        [BsonElement("Email")]
        public string? Email { get; set; } = null;

        [BsonElement("Password")]
        public string? Password { get; set; } = null;

        [BsonElement("AccountType")]
        public string? AccountType { get; set; } = null;

        [BsonElement("Address")]
        public string? Address { get; set; } = null;

        [BsonElement("LoginCounter")]
        public int LoginCounter { get; set; } = 0;

        [BsonElement("PartorFullTime")]
        public string? PartOrFullTime { get; set; } = null;

        [BsonElement("Advisor")]
        public string? Advisor { get; set; }

        [BsonElement("Holds")]
        public string? Holds { get; set; } = null;

        [BsonElement("PhoneNumber")]
        public string? PhoneNumber { get; set; } = null;

        [BsonElement("Department")]
        public string? Department { get; set; } = null;

        [BsonElement("UserID")]
        public string UserID { get; set; }
    }


    public class Transcript
    {
        [BsonElement("CourseName")]
        public string CourseName { get; set; }

        [BsonElement("Credits")]
        public int Credits { get; set; }

        [BsonElement("CRN")]
        public int CRN { get; set; }

        [BsonElement("Semester")]
        public string Semester { get; set; }

        [BsonElement("Building")]
        public int Building { get; set; }

        [BsonElement("RoomID")]
        public int RoomID { get; set; }

        [BsonElement("StartDate")]
        public DateTime StartDate { get; set; }

        [BsonElement("EndDate")]
        public DateTime EndDate { get; set; }

        [BsonElement("CourseID")]
        public int CourseID { get; set; }

        [BsonElement("StudentData")]
        public StudentData? StudentData { get; set; }

    }

    public class Schedule
    {
        [BsonElement("CourseName")]
        public string CourseName { get; set; }

        [BsonElement("Credits")]
        public int Credits { get; set; }

        [BsonElement("CRN")]
        public int CRN { get; set; }

        [BsonElement("Semester")]
        public string Semester { get; set; }

        [BsonElement("Building")]
        public int Building { get; set; }

        [BsonElement("RoomID")]
        public int RoomID { get; set; }

        [BsonElement("StartDate")]
        public DateTime StartDate { get; set; }

        [BsonElement("EndDate")]
        public DateTime EndDate { get; set; }

        [BsonElement("CourseID")]
        public int CourseID { get; set; }


        [BsonElement("StudentData")]
        public StudentData? StudentData { get; set; }
    }

    public class StudentData
    {
        [BsonElement("StudentID")]
        public string StudentID { get; set; }

        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("Major")]
        public string Major { get; set; }

        [BsonElement("Minor")]
        public string Minor { get; set; }

        [BsonElement("Grade")]
        public List<string>? Grade { get; set; }

    }

}