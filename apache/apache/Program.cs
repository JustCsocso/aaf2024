using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

//[Dec 15 2024, 19:09:18]
//18:48:01
//(iPhone; CPU iPhone OS 14_6 like Mac OS X)


string text = File.ReadAllText("adatok.txt");

Regex minta = new Regex(@"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})");

Regex referer = new Regex(@"https://(\S+)");

Regex egesz = new Regex(@"(\S+) - - \[(.+)] ""(\S+) (/\S+) (.+)"" (\d+) (\d+) ""(https://\S+|-)"" ""(.+)""");

Regex zaroje = new Regex(@"(\d{1,2}\:\d{1,2}\:\d{1,2})");

Regex moz = new Regex(@"(""\w+\/\d+\.\d+) ");


var telefon=tel.Matches(text);
foreach (Match match in telefon)
{
    Console.WriteLine(match);
}
/*
var mozi = moz.Matches(text);
Console.WriteLine(mozi.Count);
foreach (Match match in mozi)
{
    Console.WriteLine(match);
}

var kuty=zaroje.Matches(text);

foreach (Match match in kuty)
{
    Console.WriteLine(match);
}
var egy = egesz.Matches(text);

//var talalat = minta.Matches(text);
//Console.WriteLine(talalat.Count);
var link = referer.Matches(text);
//Console.WriteLine(text);
//Console.WriteLine(talalat.Count);
//Console.WriteLine(link);
//Console.WriteLine();

Dictionary<string,int> list = new Dictionary<string,int>();
foreach (Match match in link)
{
    if (list.ContainsKey(match.Value))
    {
        list[match.Value]++; 
    }
    else
    {
        list.Add(match.Value, 1);
    }
}

foreach(KeyValuePair<string,int> match in list)
{
    Console.WriteLine(match);
}



foreach (Match match in egy)
{
    Console.WriteLine(match.Groups[3]);
    //Console.WriteLine(match);
}
*/