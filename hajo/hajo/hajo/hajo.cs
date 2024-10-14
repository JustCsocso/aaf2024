using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hajo
{
    internal class hajo:Ihajo
    {
        public int hossz {  get; set; }

        public int merules {  get; set; }

        public int vizkiszoritas {  get; set; }

        public string nev {  get; set; }

        public hajo(string nev, int hossz)
        {
            this.nev = nev;
        }

        public hajo(string nev, int hossz) 
        { 

        }





        public void megfordul()
        {

        }
        public void sullyed()
        {

        }
        public void hangjelzes()
        {

        }
    }
}
