using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Database
{
    public class AllUser
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

        [BsonElement("MajorID")]
        public ObjectId? MajorID { get; set; } = null;

        [BsonElement("MinorID")]
        public ObjectId? MinorID { get; set; } = null;

        [BsonElement("Major")]
        public string? Major { get; set; } = null;

        [BsonElement("Minor")]
        public string? Minor { get; set; } = null;

        [BsonElement("FirstName")]
        public string? FirstName { get; set; } = null;

        [BsonElement("LastName")]
        public string? LastName { get; set; } = null;

        [BsonElement("Birthday")]
        public string? Birthday { get; set; } = null;

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

        [BsonElement("CreditsEarned")]
        public int CreditsEarned { get; set; } = 0;

        [BsonElement("AdvisorID")]
        public BsonObjectId AdvisorID { get; set; }

        [BsonElement("Advisor")]
        public string? Advisor { get; set; }

        [BsonElement("Holds")]
        public string? Holds { get; set; } = null;

        [BsonElement("PhoneNumber")]
        public string? PhoneNumber { get; set; } = null;

        [BsonElement("Department")]
        public string? Department { get; set; } = null;

        [BsonElement("ClassCount")]
        public int ClassCount { get; set; } = 0;

        [BsonElement("Transcript")]
        public List<Transcript> Transcript { get; set; }

        /*
        [BsonElement("Schedule")]
        public List<Schedule>? Schedule { get; set; }
        */
        [BsonElement("StudentID")]
        public string StudentID { get; set; }
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

        [BsonElement("Grade")]
        public string Grade { get; set; }

        [BsonElement("CourseID")]
        public int CourseID { get; set; }

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

        public string? Grade { get; set; } = null;


        [BsonElement("CourseID")]
        public int CourseID { get; set; }
    }

    public class StudentData
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Major { get; set; }

        public string Minor { get; set;}

        public string[] Grade { get; set; }
    }






}