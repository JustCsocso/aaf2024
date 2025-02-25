using rgb;

List<pixel> pontok = new List<pixel>();

StreamReader olvas = new StreamReader("kep.txt");
int x = 0;
int y = 0;

while (!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    string[] vag = line.Split(" ");
    x = 0;
    for (int i = 0; i < vag.Length; i += 3)
    {
        int r = int.Parse(vag[i]);
        int g = int.Parse(vag[i] + 1);
        int b = int.Parse(vag[i + 2]);

        pontok.Add(new pixel(0, 0, new adatok(r, g, b)));
        x++;
    }
    y++;
}

olvas.Close();


Console.WriteLine("2. feladat:");
Console.WriteLine("Kérek egy képpont adatait: ");
Console.WriteLine("Sor: ");
int sor = int.Parse(Console.ReadLine());
Console.WriteLine("Oszlop: ");
int oszlop = int.Parse(Console.ReadLine());

var talalat = pontok.Where(pont => pont.x == oszlop && pont.y == sor).First();


Console.WriteLine("A keppont szine {0}", talalat.rgb);

var vilagosok = pontok.Where(vilagos => vilagos.rgb.vilagos()).ToList();
Console.WriteLine($"3. Feladat: A vilagosok keppontok szama {vilagosok.Count}");

int legsevesebb = pontok.Min(sotet => sotet.rgb.osszeg());
Console.WriteLine("4. Feladat: A legsotetebb pont RGB osszege: {0}", legsevesebb);

List<string> sotetek = pontok
    .Where(pont => pont.rgb.osszeg() == legsevesebb) //legsotetebb keppontok
    .Select(pont => pont.rgb.ToString()) //csak szinek legyenek
    .ToList(); //legyen lista a halmazbol

Console.WriteLine("A legsotetebb pixelek szine: ");

Console.WriteLine(string.Join("\n", sotetek));

static bool hatar(List<pixel>  pontok, int sor, int elteres);
{
    var uj= pontok.Where(p=> p.y ==sor).ToList();
    List<int> deltaB= new List<int>();
    for(int i = 0; i < uj.Count - 1; i++)
    {
        deltaB.Add(Math.Abs(uj[i].rgb.b - uj[i+1].rgb.b));
    }
    return deltaB.Where(b=>b>elteres).ToList().Count>0;
    
}