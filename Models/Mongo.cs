using MongoDB.Bson;
using MongoDB.Driver;
using CollegeWebsite2.Models;

public class Mongo
{
    private IMongoDatabase db;

    public Mongo(string database)
    {
        var client = new MongoClient("mongodb+srv://admin:2bRNijsPDrHkwcb2@college-site.ot9hk.mongodb.net/college-site-2");
        db = client.GetDatabase(database);
    }

    public void InsertRecord<T>(string table, T record)
    {
        var collection = db.GetCollection<T>(table);
        collection.InsertOne(record);
    }

    public List<T> LoadRecord<T>(string table)
    {
        var collection = db.GetCollection<T>(table);

        return collection.Find(new BsonDocument()).ToList();
    }

    public T LoadRecordById<T>(string table, BsonBinaryData id)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("Id", id);

        return collection.Find(filter).First();
    }

    public T LoadRecordByString<T>(string table, string field, string search)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq(field, search);

        return collection.Find(filter).First();
    }

    public void UpsertRecord<T>(string table, BsonBinaryData id, T record)
    {
        var collection = db.GetCollection<T>(table);

        var result = collection.ReplaceOne(new BsonDocument("_id", id), record, new ReplaceOptions { IsUpsert = true });
    }
}