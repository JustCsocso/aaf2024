using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgb
{
    internal class pixel
    {
        public int x;
        public int y;
        public adatok rgb;
        public pixel(int x, int y, adatok rgb)
        {
            this.x = x;
            this.y = y;
            this.rgb = rgb;
        }
    }
}
