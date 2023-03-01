using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class AllUser
    {
        [BsonId]
        public ObjectId Id {get; set;}
        [BsonElement("Schedule")]
        public string[]? Schedule {get; set;}
        [BsonElement("SchedulePlainText")]
        public string[]? SchedulePlainText {get; set;}
        [BsonElement("ScheduleGrades")]
        public string[]? ScheduleGrades {get; set;}
        
        [BsonElement("Transcript")]
        public string[]? Transcript {get; set;}

        [BsonElement("TranscriptCredits")]
        public string[]? TranscriptCredits {get; set;}

        [BsonElement("TranscriptPlainText")]
        public string[]? TranscriptPlainText {get; set;}
        
        [BsonElement("TranscriptGrades")]
        public string[]? TranscriptGrades {get; set;}

        [BsonElement("Major")]
        public string Major {get; set;} = String.Empty;

        [BsonElement("Minor")]
        public string Minor {get; set;} = String.Empty;
        
        [BsonElement("FirstName")]
        public string FirstName {get; set;} = String.Empty;
        
        [BsonElement("LastName")]
        public string LastName {get; set;} = String.Empty;

        [BsonElement("Birthday")]
        public string Birthday {get; set;} = String.Empty;

        [BsonElement("Email")]
        public string Email {get; set;} = String.Empty;

        [BsonElement("Password")]
        public string Password {get; set;} = String.Empty;

        [BsonElement("AccountType")]
        public string AccountType {get; set;} = String.Empty;

        [BsonElement("Address")]
        public string Address {get; set;} = String.Empty;
        
        [BsonElement("LoginCounter")]
        public int LoginCounter {get; set;}

        [BsonElement("PartOrFullTime")]
        public string PartOrFullTime {get; set;} = String.Empty;

        [BsonElement("CreditsEarned")]
        public int CreditsEarned {get; set;} 

        [BsonElement("Advisor")]
        public string Advisor {get; set;} = String.Empty;
        
        [BsonElement("Holds")]
        public string Holds {get; set;} = String.Empty;
        
        [BsonElement("PhoneNumber")]
        public string PhoneNumber {get; set;} = String.Empty;

        [BsonElement("Department")]
        public string Department {get; set;} = String.Empty;
        
        [BsonElement("ClassCount")]
        public int ClassCount {get; set;}
        
        [BsonElement("Attendance")]
        public string Attendance{get; set;} = String.Empty;
    }
}