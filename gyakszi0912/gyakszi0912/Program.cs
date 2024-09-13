static int szamBekeres(int minimun=3, int maximum = 15)
{
    if (minimun > maximum)
    {
        throw new ArgumentOutOfRangeException("A minimum nem lehet nagyobb, mint a maximum");
    }
    int szam = 0;
    while (szam == 0)
    {
        try
        {
            Console.Write("Kérek egy számot: {0} és {1} között: ", minimun, maximum);
            szam = Convert.ToInt32(Console.ReadLine());
            if (szam < minimun || szam > maximum)
            {
                throw new Exception();
            }
        }
        catch
        {
            szam = 0;
        }

    }
   

    return szam;
}

static string szoGeneralas(int hossz)
{
    string[] betuk = { "euioöüóőúűáéaí","qwrtzpsdfghjklyxcvbnm" };

    Random rand = new Random();
    int melyikjon = rand.Next(2);

    string vissza = "";
    for(int i = 0; i < hossz; i++)
    {
        /*
        string ebbolkellValasztani = betuk[melyikjon];
        int valasztasiHossz=ebbolkellValasztani.Length;
        int valasztottBetuSzama = rand.Next(valasztasiHossz);
        string valasztottBetu = ebbolkellValasztani[valasztottBetuSzama].ToString();
        vissza += valasztottBetu;
        */

        vissza += betuk[melyikjon][rand.Next(betuk[melyikjon].Length)];
    }


    return vissza;
}

static List<string> sokSzo(int hossz, int darab=200)
{
    List<string> list = new List<string>();
    for(int i = 0; i < 200; i++)
    {
        list.Add(szoGeneralas(hossz));
    }

    return list;
}

static void filebaIr(List<string> szavak1)
{
    StreamWriter ir = new StreamWriter("sok-sok-szo.txt");
    for(int i = 0;i < szavak1.Count; i++)
    {
        ir.WriteLine(szavak1[i]);
    }
    ir.Close();
}

static void Main(string[] args)
{
    //szamBekeres(5, 10);
    
}
int betuSzam = szamBekeres(5, 10);
//Console.WriteLine(szoGeneralas(6));
List<string> szavak = sokSzo(betuSzam);
filebaIr(szavak);
//Console.WriteLine(szavak[45]);