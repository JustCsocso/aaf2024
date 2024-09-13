using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakszi0913
{
    internal class kutya
    {
        public string nev;

        public kutya(string nev)
        {
            this.nev = nev;
            Console.WriteLine("Kutya létrejott");
        }
        public void ugat() 
        {
            Console.WriteLine("Vau");
        }

        public float _suly;

        public float suly 
        {
            get
            {
                return _suly;
            }
                 
            set
            {
                _suly = value;
            }
        }
        public override string ToString() {
            return "kutya: " + nev + ", súly" + _suly;
        }
        static string ezMiEz()
        {
            return "Ez egy kutya objektum";
        }
    }
}
