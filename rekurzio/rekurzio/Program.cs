using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eredeti = "alma";
            string forditott = ReverseString(eredeti);

            Console.WriteLine($"Eredeti: {eredeti}"); 
            Console.WriteLine($"Fordított: {forditott}"); 
        }

        static string ReverseString(string str)
        {
            
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
