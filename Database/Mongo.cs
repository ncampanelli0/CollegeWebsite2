using MongoDB.Bson;
using MongoDB.Driver;
using CollegeWebsite2.Database;

/// <summary>
///  <c>Mongo:</c> connect to the database 
/// </summary>
public class Mongo
{
    private IMongoDatabase db;

    /// <summary>
    /// constructor: requires string of database to connect to
    /// </summary>
    /// <param name="database">string of the table to connect to</param>
    public Mongo(string database)
    {
        var client = new MongoClient("mongodb+srv://admin:2bRNijsPDrHkwcb2@college-site.ot9hk.mongodb.net/college-site-2");
        db = client.GetDatabase(database);
    }

    /// <summary>
    /// Inserts a record (values) into the database
    /// </summary>
    /// <typeparam name="T">specifies the model to be used</typeparam>
    /// <param name="table">specfies which collection to write to</param>
    /// <param name="record">specifies what values to write (bson format)</param>
    public void InsertRecord<T>(string table, T record)
    {
        var collection = db.GetCollection<T>(table);
        collection.InsertOne(record);
    }

    /// <summary>
    /// loads an entire record from the database and converts it to a list.
    /// </summary>
    /// <typeparam name="T">specfies the type of model to grab (which fields)</typeparam>
    /// <param name="table">specfies which table to search</param>
    /// <returns>a list of the specfied table using the fields assigned in T</returns>
    public List<T> LoadRecord<T>(string table)
    {
        var collection = db.GetCollection<T>(table);

        return collection.Find(new BsonDocument()).ToList();
    }

    public List<T> LoadSortedRecord<T>(string table, string field)
    {
        var collection = db.GetCollection<T>(table);

        var sort = Builders<T>.Sort.Descending(field);

        return collection.Find(new BsonDocument()).Sort(sort).ToList();
    }

    /// <summary>
    /// loads the first found document matching the specified id in the specified table
    /// </summary>
    /// <typeparam name="T">specfies the type of model to grab (which fields)</typeparam>
    /// <param name="table">specifies which collection to read from</param>
    /// <param name="id">specfies which id to search for</param>
    /// <returns>the first id to match in the table</returns>
    public T LoadRecordById<T>(string table, BsonObjectId id)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq("Id", id);
        return collection.Find(filter).First();
    }

    /// <summary>
    /// loads the first found document matching the specified search string in the specified table and field
    /// </summary>
    /// <typeparam name="T">specfies the type of model to grab (which fields)</typeparam>
    /// <param name="table">specifies which table to use</param>
    /// <param name="field">specfies which field (row) to use</param>
    /// <param name="search">string to search by</param>
    /// <returns>the first found document that matches the string in the table</returns>
    public T LoadRecordByString<T>(string table, string field, string search)
    {
        var collection = db.GetCollection<T>(table);
        var filter = Builders<T>.Filter.Eq(field, search);

        return collection.Find(filter).First();
    }

    /// <summary>
    /// updates a record, if it doesn't exist creates it instead
    /// </summary>
    /// <typeparam name="T">specfies the type of model to grab (which fields)</typeparam>
    /// <param name="table">specifies which collection to search</param>
    /// <param name="id">specifies which id to search by</param>
    /// <param name="record">specifies the data to be updated or added (bson format)</param>
    public void UpsertRecord<T>(string table, BsonObjectId id, T record)
    {
        var collection = db.GetCollection<T>(table);

        var result = collection.ReplaceOne(new BsonDocument("_id", id), record, new ReplaceOptions { IsUpsert = true });
    }
}