using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    internal class NyelvAdat
    {
        public string nyelv;
        public List<evAdat> vizsgak=new List<evAdat>();
        public NyelvAdat(string sor, int[]evszamok) 
        {
            string[]vag=sor.Split(';');
            nyelv=vag[0];
            this.nyelv=vag[1];
        }
        public NyelvAdat(string nyelv, int[] adatok, int[]evszamok)
        {
            this.nyelv = nyelv;
            for(int i = 0; i < adatok.Length; i++)
            {
                this.vizsgak.Add(new evAdat(evszamok[i],adatok[i]));
            }
        }
    }
}
