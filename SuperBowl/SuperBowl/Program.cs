
StreamReader olvas = new StreamReader("SuperBowl.txt");

List<string> adatok=new List<string>();

List<string> Ssz = new List<string>();
List<string> Datum = new List<string>();
List<string> Gyoztes = new List<string>();
List<string> Vesztes = new List<string>();
List<string> Helyszin = new List<string>();
List<string> VarosAllam = new List<string>();
List<string> Nezoszam = new List<string>();

while (!olvas.EndOfStream)
{
    
    string line = olvas.ReadLine();
    string[] vag = line.Split(",");
    Ssz.Add(vag[0]);
    Datum.Add(vag[1]);
    Gyoztes.Add(vag[2]);
    Vesztes.Add((vag[3]));
    Helyszin.Add(vag[4]);
    VarosAllam.Add(vag[5]);
    Nezoszam.Add(vag[6]);

}
foreach (string x in adatok)
{
    Console.WriteLine(x);
}
olvas.Close();