// MIS 3033 002
// September 20, 2023
// Braden Fisher, 113492081

using a;
using System.Text.Json;

Console.WriteLine("City Database");

CityDB db;
db = new CityDB();// create the database connection

string rStr;// result string
string filePath = "data.json";

var opt = new JsonSerializerOptions();
opt.WriteIndented = true;

{
    var r1 = db.cityTbl.Where(c => c.State == "Oklahoma");
    rStr = JsonSerializer.Serialize(r1, opt);// where funciton will always result in a table (collection of cities)
    // Console.WriteLine(rStr);
    File.WriteAllText(filePath, rStr);
}
// all rows
{
    // IEnumerable<City> r1 = db.cityTbl;// collection
    List<City> r1 = db.cityTbl.ToList();
    for (int i = 0; i < r1.Count; i++)
    {
        Console.WriteLine(r1[i]);
    }
    rStr = JsonSerializer.Serialize(r1, opt);
    // Console.WriteLine(rStr);
    File.WriteAllText(filePath, rStr);
}
//add one row
// {
//     City newCity; // City, complex
//     newCity = new City() {Name = "MIS3033", State = "Tx", Population = 26, Lat = 0, Lon = 0};
//     newCity.Id = 1000;
// 
//     db.cityTbl.Add(newCity); // collection
// 
//     db.SaveChanges(); // save to the database file
// 
//     var r1 = db.cityTbl.Where(c => c.State == "Oklahoma");
//     rStr = JsonSerializer.Serialize(r1, opt);
//     // Console.WriteLine(rStr);
//     File.WriteAllText(filePath, rStr);
// }

{
    // var r1 = db.cityTbl.Where(c => c.State == "Texas").Where(c => c.Population > 1000000);
    // City r1 = db.cityTbl.Where(c => c.State == "Texas" && c.Population > 1000000).FirstOrDefault();
    // var r1 = db.cityTbl.Where(c => c.State == "Texas").OrderByDescending(x => x.Population);
    // var r1 = db.cityTbl.OrderByDescending(x => x.Population).FirstOrDefault();
    // r1.Population = 4000000;
    // db.SaveChanges();

    // db.cityTbl.Remove(r1);
    // db.SaveChanges();

    // var r1 = db.cityTbl.Min(x => x.Population); // returns a single number 
    var r1 = db.cityTbl.ToList().MaxBy(x => x.Population);
    // min max
    // average double
    // minby
    rStr = JsonSerializer.Serialize(r1, opt);
    // Console.WriteLine(rStr);
    File.WriteAllText(filePath, rStr);
}