using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class Advisor
    {

        [BsonId]
        public BsonObjectId Id { get; set; }

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
        public int? LoginCounter { get; set; } = null;
        [BsonElement("PartorFullTime")]
        public string? PartOrFullTime {get; set;} = null;
        
        [BsonElement("PhoneNumber")]
        public string? PhoneNumber {get; set;} = null;

        

    }
}