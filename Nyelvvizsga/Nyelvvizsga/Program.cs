
using Nyelvvizsga;

List<NyelvAdat> sikeres = new List<NyelvAdat>();
List<NyelvAdat> sikertelen= new List<NyelvAdat>();
static void fajlBe(string fajlnev)
{
    StreamReader olvas= new StreamReader(fajlnev);
    while( olvas.EndOfStream)
    {
        string line= olvas.ReadLine();
    }
    olvas.Close();
}