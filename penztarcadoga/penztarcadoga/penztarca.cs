using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penztarcadoga
{
    internal class penztarca
    {
        public int kp;
        public int hitel;
        

        public penztarca(int kp)
        {
            this.kp = kp;
            this.hitel = hitel;
            
        }

        public static penztarca operator -(penztarca a, penztarca b)
        {
            return new penztarca(a.kp - b.kp);
        }
        public static penztarca operator -(penztarca a, int b)
        {
            return new penztarca(a.kp - b);
        }
        public static penztarca operator -(int a, penztarca b)
        {
            return new penztarca(a - b.kp);
        }

        public static penztarca operator +(penztarca a, penztarca b)
        {
            return new penztarca(a.kp + b.kp);
        }
        public static penztarca operator +(int a, penztarca b)
        {
            return new penztarca(a + b.kp);
        }
        public static penztarca operator +(penztarca a, int b)
        {
            return new penztarca(a.kp + b);
        }

        public override string ToString()
        {
            return $"{kp}";
        }

    }
}
