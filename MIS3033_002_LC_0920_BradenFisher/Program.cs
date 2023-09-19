// MIS 3033 002
// September 20, 2023
// Braden Fisher, 113492081

using a;
using System.Text.Json;

Console.WriteLine("City Database");

CityDB db;
db = new CityDB();// create the database connection

string rStr;// result string
string filePath = "data.txt";

var opt = new JsonSerializerOptions();

var r1 = db.cityTbl.Where(c => c.State == "Oklahoma");

opt.WriteIndented = true;
rStr = JsonSerializer.Serialize(r1, opt);// where funciton will always result in a table (collection of cities)
Console.WriteLine(rStr);

File.WriteAllText(filePath, rStr);