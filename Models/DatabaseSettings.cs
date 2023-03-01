using MongoDB.Driver;
using MongoDB.Bson;
using CollegeWebsite2.Models;

public class DatabaseSettings
{
    public void test()
    {
        var client = new MongoClient("mongodb+srv://admin:2bRNijsPDrHkwcb2@college-site.ot9hk.mongodb.net/college-site-2");
        var database = client.GetDatabase("college-site-2");
        var advisor = database.GetCollection<Advisor>("advisor");

        var reggie = advisor.Find(g => g.FirstName == "Reggie").ToList();

        Console.WriteLine(reggie);

    }
}