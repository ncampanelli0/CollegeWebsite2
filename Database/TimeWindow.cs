using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CollegeWebsite2.Database
{
    public class TimeWindow
    {
        [BsonId]
        public BsonObjectId Id { get; set; }

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

    }
}
