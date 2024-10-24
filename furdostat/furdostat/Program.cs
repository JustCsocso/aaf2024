List<int> azonosito = new List<int>();
List<int> reszleg = new List<int>();
List<int> beki = new List<int>();
List<int> ora = new List<int>();
List<int> perc = new List<int>();
List<int> masperc = new List<int>();



string[] tomb = File.ReadAllLines("furdoadat.txt");

for (int i = 1; i < tomb.Length; i++)
{
    string[] vag = tomb[i].Split(" ");
    azonosito.Add(Convert.ToInt32(vag[0]));
    reszleg.Add(Convert.ToInt32(vag[1]));
    beki.Add(Convert.ToInt32(vag[2]));
    ora.Add(Convert.ToInt32(vag[3]));
    perc.Add(Convert.ToInt32(vag[4]));
    masperc.Add(Convert.ToInt32(vag[5]));
}
Console.WriteLine("2.feladat");
Console.WriteLine("Az első vendég {0}:{1}:{2} - kor lépett ki az öltözőből",ora[0],perc[0],masperc[0]);
Console.WriteLine("Az utolsó vendég {0}:{1}:{2} - kor lépett ki az öltözőből",ora[^1],perc[^1],masperc[^1]);

Console.WriteLine("3.feladat: ");

/*foreach (string s in reszleg)
{

}
*/
Console.WriteLine("5.feladat: ");
List<int> ido = new List<int>();
List<int> kutya = new List<int>();

for (int i = 0; i < ora.Count; i++)
{
    if (ora[i] > 5 && ora[i] < 9)
    {
        ido.Add(ora[i]);
    }
    else if (ora[i] > 8 && ora[i] < 16) 
    {
        ido.Add(kutya[i]);
    }
}
Console.WriteLine("6-9 óra között {0} volt", ido.Count);
Console.WriteLine("9-16 óra között {0} volt", ido.Count);
