using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class AllUser
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;}
        
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Schedule")]
        public string[]? Schedule {get; set;}


        [BsonElement("SchedulePlainText")]
        public string[]? SchedulePlainText {get; set;}

        [BsonElement("ScheduleGrades")]
        public string[]? ScheduleGrades {get; set;}

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Transcript")]
        public string[]? Transcript {get; set;}

        [BsonElement("TranscriptCredits")]
        public int[]? TranscriptCredits {get; set;}

        [BsonElement("TranscriptPlainText")]
        public string[]? TranscriptPlainText {get; set;}
        
        [BsonElement("TranscriptGrades")]
        public string[]? TranscriptGrades {get; set;}

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Major")]
        public string? Major {get; set;}

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Minor")]
        public string? Minor {get; set;}
        
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

        [BsonElement("PartorFullTime")]
        public string PartOrFullTime {get; set;} = String.Empty;

        [BsonElement("CreditsEarned")]
        public int CreditsEarned {get; set;}

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Advisor")]
        public string? Advisor {get; set;}
        
        [BsonElement("Holds")]
        public string Holds {get; set;} = String.Empty;
        
        [BsonElement("PhoneNumber")]
        public string PhoneNumber {get; set;} = String.Empty;

        [BsonElement("Department")]
        public string Department {get; set;} = String.Empty;
        
        [BsonElement("ClassCount")]
        public int ClassCount {get; set;}
    }
}