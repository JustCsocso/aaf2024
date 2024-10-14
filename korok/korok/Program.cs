List<string> kord = new List<string>();

StreamReader olvas = new StreamReader("Korok.txt");

while (!olvas.EndOfStream)
{
    kord.Add(olvas.ReadLine());
}
olvas.Close();

foreach (string k in kord)
{
    //Console.WriteLine(k); 
}

Console.WriteLine("2.feladat: ");
Console.WriteLine("1.negyed:");

