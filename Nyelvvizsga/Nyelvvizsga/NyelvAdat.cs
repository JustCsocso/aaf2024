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
            int[] adatok=new int[vag.Length-1];
            for (int i = 0; i < vag.Length; i++) 
            {
                adatok[i]=int.Parse(vag[i]);
            }
            segedKomstruktor(nyelv, adatok, evszamok);
        }

        public void segedKomstruktor(string nyelv, int[] adatok ,int[]evszamok) 
        {
            segedKomstruktor(nyelv, evszamok, adatok);
        }
        public NyelvAdat(string nyelv, int[] adatok, int[] evszamok) 
            {
            segedKomstruktor(nyelv, adatok, evszamok);
                }
        public void segedKonstruktor(string nyelv, int[] adatok, int[] evszamok)
        {
            this.nyelv = nyelv;
            for (int i = 0; i < adatok.Length; i++)
            {
                this.vizsgak.Add(new evAdat(evszamok[i], adatok[i]));
            }
        }
    }
}
