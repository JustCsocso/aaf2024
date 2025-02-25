using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace tanciskola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
            StreamReader olvas = new StreamReader("tancrend.txt");
            
            while (!olvas.EndOfStream) 
            {
                string line = olvas.ReadLine();
                string[] vag=line.Split('\n');

                }

            }
            olvas.Close();
            Console.WriteLine("2.feladat");
           
            */
            List<adatok> tancok = new List<adatok>();
            string[] olvas = File.ReadAllLines("tancrend.txt");
            
            for (int i = 0; i < olvas.Length; i += 3)
            {
                tancok.Add(new adatok(olvas[i], olvas[i + 1], olvas[i + 2]));
            }
            Console.WriteLine("2. feladat:");
            Console.WriteLine($"első tánc: {tancok.First().tanc},utolsó tánc: {tancok.Last().tanc}");


            Console.WriteLine("3. feladat");
            var samba = tancok.Where(tanc => tanc.tanc == "samba");
            Console.WriteLine($"összes samba tanc:{samba.Count()}");

            Console.WriteLine("4. feladat:");
            var vilma = tancok.Where(lany => lany.lany == "Vilma").Select(tanc => tanc.tanc).ToList();
            Console.WriteLine($"Vilma az alábbi táncokban szerepelt: {String.Join(", ", vilma)}");

            Console.WriteLine("5.feladat");
            Console.WriteLine("Kérek egy táncot: ");
            string tancocska=Console.ReadLine();
            var vilmapar=tancok.Where(tanc=>tanc.tanc==tancocska && tanc.lany=="Vilma").Select(fiu=>fiu.fiu).ToList();

            if(vilmapar.Count > 0)
            {
                Console.WriteLine($"Vilma párja {tancocska}-nál {String.Join(",",vilmapar)}-volt");

            }
            else
            {
                Console.WriteLine($"Vilma nem táncolt {tancocska}-t");
            }
            
        }
    }
}
