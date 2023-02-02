
using Newtonsoft.Json.Linq;
using WeatherApp;

string key = File.ReadAllText("appsettings.json");
string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

Console.WriteLine("Please enter the zipcode");
string zipCode = Console.ReadLine();

string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIkey}&units=imperial";
var temp = Weather.GetTemp(apiCall);

Console.WriteLine();
Console.WriteLine($"It is cirrently {Weather.GetTemp(apiCall)} degrees F in that location.");