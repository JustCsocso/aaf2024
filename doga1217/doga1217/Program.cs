using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

string text = File.ReadAllText("adatok.txt");

Regex egesz = new Regex(@"(\S+) - - \[(.+)] ""(\S+) (/\S+) (.+)"" (\d+ \d+) ""(https://\S+|-)"" ""(.+)""");
/*var telefon = egesz.Matches(text);
foreach (Match match in telefon)
{
    Console.WriteLine(match);
}
*/

Regex nem200 = new Regex(@" (\d{1,3}) ");
Regex moz = new Regex(@"(""\w+\/\d+\.\d+) ");

Regex log2 = new Regex(@"\[(.+)]");

var logos=log2.Matches(text);
foreach (Match match in logos)
{
    Console.WriteLine(match);
}


var nem = nem200.Matches(text);
var mozilla=moz.Matches(text);
int valami2 = 0;
foreach (Match match in mozilla)
{

    if (!moz.IsMatch("Mozilla /5.0"))
    {
        valami2++;

    }
    else
    {
        Console.WriteLine("Van mas bongeszo");
    }


    //Console.WriteLine(match);
}
Console.WriteLine(valami2 + " Csak Mozilla");
int szia = 0;
foreach (Match match in nem)
{
    if (match.Value != "200")
    {
        szia++;
        
    }
    //Console.WriteLine(match);
    
}
Console.WriteLine(szia);

/*
for (int i = 0; i < igen.Count; i++)
{
    if ()
    
    {

    }
}
*/

//int[] ints = new int [];

//Console.WriteLine(match);

/*
foreach (Match match in igen)
{
    if (valami.ContainsKey(match.Value))
    {
        valami[match.Value]++;
    }
    else
    {
        valami.Add(match.Value, 1);
    }
}





foreach (Match match in igen)
{
    if (valami.ContainsKey(match.Value))
    {
        
    }
    
}
*/