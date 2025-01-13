<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
=======
﻿
using System.Text.RegularExpressions;

string adatok = File.ReadAllText("bedat.txt");
Console.WriteLine(adatok);

Console.WriteLine("2.feladat");
Regex ido = new Regex(@"(\d+\:\d+)");
var idos= ido.Matches(adatok);
foreach(Match match in idos)
{

}


    

>>>>>>> 2a9d0ab6f5715ff3099a00024c4d7cd09e901354
