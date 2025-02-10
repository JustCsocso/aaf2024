using erettsegi;
using System.Globalization;

string[] text = File.ReadAllLines("felajanlas.txt");

List<Adatok> viragok = new List<Adatok>();

/*
foreach (string line in text.Skip(1))
{
    viragok.Add(new Adatok(line));
}
int agyasdb = int.Parse(text[0]);
*/

viragok = text.Skip(1).Select(sor => new Adatok(sor)).ToList();

for (int i = 0; i < viragok.Count; i++)
{
    viragok[i].sorszam = i + 1;
}

Console.WriteLine("2.: A felajánlások száma: {0}", viragok.Count);

/*
List<int> kapudb = new List<int>();
foreach (Adatok e in viragok)
{
    if (e.kapubentvan) {  kapudb.Add(e.sorszam); }
}
Console.WriteLine("3.: A bejárat mindkét oldalán ültetők: {0}", string.Join(" ", kapudb));
*/
Console.WriteLine("3.: A bejárat mindkét oldalán ültetők: {0}", string.Join(" ", viragok.Where(e => e.kapubentvan).Select(e => e.sorszam)));

Console.Write("4. feladat:\nAdja meg az ágyás sorszámát:");
int be=int.Parse(Console.ReadLine());

int darab = 0;
string szin = "";
for(int i = 0; i < viragok.Count; i++)
{
    if (viragok[i].BenneVanEz(be))
    {
        darab++;
        if (szin == "")
        {
            szin = viragok[i].szin;
        }
        
    }
    Console.WriteLine("A felajánlók száma:{0}", darab);
}

if (darab == 0)
{
    Console.WriteLine("Ezt az ágyást nem ültetik be.");
}
else
{
    Console.WriteLine(szin);
}

List<Adatok> szurt = viragok.Where((elem) => elem.BenneVanEz(be)).ToList();
Console.WriteLine("a felajánlók száma: {0}", szurt.Count());

if(szurt.Count== 0)
{
    Console.WriteLine("Ezt az ágyást nem ültetik be.");
}
else
{
    Console.WriteLine("{0}",szurt.First().szin);
    Console.WriteLine("{0}", String.Join(" ", szurt.Select(elem => elem.szin).Distinct()));  
}