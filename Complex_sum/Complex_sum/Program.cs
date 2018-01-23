using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_sum
{
    class Complex
    {
        int num, denom;

        public Complex() { }
        
        public Complex( int _x, int _y)
        {
            num = _x;
            denom = _y;
        }

        public static int FindGCD (int a, int b)
        {
            int d, r, oldr;
            if (a>b)
            {
                d = a;
                r = b;
    
                while(r!=0)
                {
                    oldr = r;
                    r = d % r;
                    d = oldr;
                }

                return d;

            }
            else if (a<b)
            {
                d = b;
                r = a;

                while (r != 0)
                {
                    oldr = r;
                    r = d % r;
                    d = oldr;
                }

                return d;
            }
            return a;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex n = new Complex();

            int gcd, lcm;

            gcd = FindGCD(c1.denom, c2.denom);

            lcm = Math.Abs(c1.denom * c2.denom) / gcd;

            n.denom = lcm;

            n.num = lcm * c1.num / c1.denom + lcm * c2.num / c2.denom;

            return n;
        }

        public override string ToString()
        {
            return num + "/" + denom;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(1, 2);

            Console.WriteLine(a + b);

            Console.ReadKey();
        }
    }
}
    