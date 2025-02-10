using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgb
{
    internal class adatok
    {
        public byte r;
        public byte g; 
        public byte b;


        public adatok(int red,int green,int blue)
        {
            r = (byte)red;
            g = (byte)green;
            b = (byte)blue;
        }
    }
}
