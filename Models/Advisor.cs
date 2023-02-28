using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CollegeWebsite2.Models
{
    public class Advisor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;} = String.Empty;
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
        [BsonElement("PhoneNumber")]
        public string PhoneNumber {get; set;} = String.Empty;

        

    }
}