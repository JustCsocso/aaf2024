
using System.Text.RegularExpressions;

string adatok = File.ReadAllText("bedat.txt");
Console.WriteLine(adatok);

Console.WriteLine("2.feladat");
Regex ido = new Regex(@"(\d+\:\d+)");
var idos= ido.Matches(adatok);
foreach(Match match in idos)
{

}


    

