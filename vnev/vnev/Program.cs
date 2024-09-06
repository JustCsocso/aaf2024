using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vnev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader knev = new StreamReader("knev.txt");
            StreamReader vnev = new StreamReader("vnev.txt");

            List<string> knevLista = new List<string>();
            List<string> vnevLista = new List<string>();
            List<string> nevek=new List<string>();
            

            while (!knev.EndOfStream)
            {
                string kereszt=knev.ReadLine();
                string vezer=vnev.ReadLine();

                knevLista.Add(kereszt);
                vnevLista.Add(vezer);
                
            }

            for (int i = 0; i<knevLista.Count; i++) 
            { 
                Console.WriteLine(knevLista[i]);
            }
            
            StreamWriter tnev = new StreamWriter("teljesnevek.txt");
            for (int i = 0; i < 100; i++) {

                tnev.WriteLine(vnevLista[i]+" " + knevLista[i]);

            }

            tnev.Close();
            
        }
    }
}
