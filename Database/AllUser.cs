using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Database
{
    public class AllUser
    {
        [BsonId]
        public BsonObjectId Id {get; set;}

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Schedule")]
        public string[]? Schedule { get; set; } = null;


        [BsonElement("SchedulePlainText")]
        public string[]? SchedulePlainText {get; set; } = null;

        [BsonElement("ScheduleGrades")]
        public string[]? ScheduleGrades {get; set; } = null;

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Transcript")]
        public string[]? Transcript {get; set; } = null;

        [BsonElement("TranscriptCredits")] public int[]? TranscriptCredits { get; set; } = null;

        [BsonElement("TranscriptPlainText")] public string[]? TranscriptPlainText { get; set; } = null;
        
        [BsonElement("TranscriptGrades")] public string[]? TranscriptGrades { get; set; } = null;

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Major")]
        public string? Major { get; set; } = null;

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Minor")]
        public string? Minor {get; set; } = null;

        [BsonElement("FirstName")] 
        public string? FirstName {get; set;} = null; 
        
        [BsonElement("LastName")]
        public string? LastName {get; set;} = null;

        [BsonElement("Birthday")]
        public string? Birthday {get; set;} = null;

        [BsonElement("Email")]
        public string? Email {get; set;} = null;

        [BsonElement("Password")]
        public string? Password {get; set;} = null;

        [BsonElement("AccountType")]
        public string? AccountType {get; set;} = null;

        [BsonElement("Address")]
        public string? Address {get; set;} = null;

        [BsonElement("LoginCounter")]
        public int LoginCounter { get; set; } = 0;

        [BsonElement("PartorFullTime")]
        public string? PartOrFullTime {get; set;} = null;

        [BsonElement("CreditsEarned")]
        public int CreditsEarned { get; set; } = 0;

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Advisor")]
        public string? Advisor {get; set;}
        
        [BsonElement("Holds")]
        public string? Holds {get; set;} = null;
        
        [BsonElement("PhoneNumber")]
        public string? PhoneNumber {get; set;} = null;

        [BsonElement("Department")]
        public string? Department {get; set;} = null;

        [BsonElement("ClassCount")]
        public int ClassCount { get; set; } = 0;
    }
}