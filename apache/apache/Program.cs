using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

string text = File.ReadAllText("adatok.txt");



Regex minta = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");

var illik = minta.Matches(text);
Console.WriteLine(illik.Count);