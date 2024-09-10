StreamReader alany = new StreamReader("alany.txt");
StreamReader jelzok = new StreamReader("jelzok.txt");
StreamReader hely = new StreamReader("hely.txt");
StreamReader ige = new StreamReader("ige.txt");

List<string> alanyok=new List<string>();
List<string> jelzo = new List<string>();
List<string> helyek = new List<string>();
List<string> igek = new List<string>();

while (!alany.EndOfStream)
{
    alanyok.Add(alany.ReadLine());
    jelzo.Add(jelzok.ReadLine());
    helyek.Add(hely.ReadLine());
    igek.Add(ige.ReadLine());
}
//Console.WriteLine(igek.Count);
foreach (string s in alanyok)
{
    Console.WriteLine(s);
}
Random rand = new Random();
for(int i = 0; i < 100; i++)
{
    int elso=rand.Next(jelzo.Count);
    int masodik=rand.Next(alanyok.Count);
    int harmadik=rand.Next(helyek.Count);
    int negy = rand.Next(igek.Count);
    Console.WriteLine("A" + jelzo[elso] + " " + alanyok[masodik] + " " + igek[negy] + " " + helyek[harmadik]);
}
alany.Close();