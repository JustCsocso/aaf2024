using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> kuty=new Dictionary<string,int>();

            StreamReader olvas = new StreamReader("koponyeg.txt");

            while (!olvas.EndOfStream)
            {
                Console.WriteLine(olvas.ReadToEnd());
            }
            olvas.Close();
        }
    }
}
